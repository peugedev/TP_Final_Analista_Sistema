using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Connection
{
    public abstract class ConnectionSQL
    {
        private readonly string _connectionString;

        protected ConnectionSQL(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException(
                    "No se encontró la cadena de conexión 'DefaultConnection'.");

            // Validación temprana: falla rápido si la cadena está mal armada
            var builder = new SqlConnectionStringBuilder(_connectionString);

            // Pooling explícito y timeouts razonables
            builder.Pooling = true;
            builder.MinPoolSize = 2;
            builder.MaxPoolSize = 100;
            builder.ConnectTimeout = 15;      // segundos para conectar
            builder.CommandTimeout = 30;      // segundos por comando (complementario)

            _connectionString = builder.ConnectionString;
        }

        /// <summary>
        /// Crea y ABRE una conexión nueva (o reutilizada del pool).
        /// El llamador es responsable de cerrarla/dispose-arla.
        /// </summary>
        protected SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Versión async (recomendada para WinForms/I/O).
        /// </summary>
        protected async Task<SqlConnection> GetConnectionAsync(
            CancellationToken cancellationToken = default)
        {
            var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync(cancellationToken).ConfigureAwait(false);
            return connection;
        }
    }
}
