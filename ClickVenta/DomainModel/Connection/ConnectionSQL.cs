using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Connection
{
    public abstract class ConnectionSQL : IDisposable
    {
        private readonly string cnn;

        public ConnectionSQL(IConfiguration configuration)
        {
            this.cnn = configuration["ConnectionStrings:DefaultConnection"];
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        protected SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(cnn);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Dispose();
            }
        }
        protected void CloseConnection(SqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            Dispose();
        }
    }
}
