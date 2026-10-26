using DomainModel.Connection.Data.Abstractions;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Connection.Data
{
    public sealed class SqlConnectionFactory : ISqlConnectionFactory
    {
        public string ConnectionString { get; }

        public SqlConnectionFactory(IConfiguration configuration)
        {
            var raw = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException(
                    "No se encontró la cadena de conexión 'DefaultConnection'.");

            var builder = new SqlConnectionStringBuilder(raw)
            {
                Pooling = true,
                MinPoolSize = 5,
                MaxPoolSize = 100,
                ConnectTimeout = 60,
                CommandTimeout = 30,
            };

            ConnectionString = builder.ConnectionString;
        }

        public SqlConnection CreateConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public async Task<SqlConnection> CreateConnectionAsync(CancellationToken ct = default)
        {
            const int maxAttempts = 5;
            var delay = TimeSpan.FromSeconds(1);
            Exception? lastException = null;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                // 🔑 Instancia NUEVA en cada intento → nunca reabrimos una conexión "sucia"
                var cn = new SqlConnection(ConnectionString);

                try
                {
                    await cn.OpenAsync(ct).ConfigureAwait(false);
                    return cn;
                }
                catch (Exception ex) when (attempt < maxAttempts && IsRetryable(ex))
                {
                    lastException = ex;

                    // 🧹 CLAVE: Si el error parece indicar un pool "envenenado",
                    //    forzamos la limpieza del pool ANTES de reintentar.
                    //    Así el próximo intento creará una conexión física nueva.
                    if (ex is SqlException ||
                    (ex is InvalidOperationException && ex.Message.Contains("pool", StringComparison.OrdinalIgnoreCase)))
                    {
                        SqlConnection.ClearAllPools();
                    }
                    // 🧹 Descartamos la conexión fallida (puede quedar en Open post-login)
                    await cn.DisposeAsync().ConfigureAwait(false);

                    await Task.Delay(delay, ct).ConfigureAwait(false);
                    delay = TimeSpan.FromSeconds(Math.Min(delay.TotalSeconds * 2, 20));
                }
                catch
                {
                    await cn.DisposeAsync().ConfigureAwait(false);
                    throw;
                }
            }

            throw new InvalidOperationException(
                $"No se pudo abrir la conexión tras {maxAttempts} intentos.", lastException);
        }

        private static bool IsRetryable(Exception ex)
        {
            // El error "connection was not closed" TAMBIÉN es retryable:
            // significa que el intento anterior dejó la conexión a medio abrir.
            if (ex is InvalidOperationException ioe &&
                ioe.Message.Contains("connection's current state is open", StringComparison.OrdinalIgnoreCase))
                return true;

            if (ex is SqlException sqlEx)
            {
                int[] transient =
                {
                    -2,                                // Timeout
                    20, 64, 233, 10053, 10054, 10060,  // Red / TCP
                    40197, 40501, 40613,               // Azure SQL
                    49918, 49919, 49920,               // Azure throttling
                    1205                               // Deadlock
                };
                return transient.Contains(sqlEx.Number);
            }

            return false;
        }
    }
}
