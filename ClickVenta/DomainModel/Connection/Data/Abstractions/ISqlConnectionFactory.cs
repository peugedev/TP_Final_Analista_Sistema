using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Connection.Data.Abstractions
{
    public interface ISqlConnectionFactory
    {
        SqlConnection CreateConnection();
        Task<SqlConnection> CreateConnectionAsync(CancellationToken ct = default);
        string ConnectionString { get; }
    }
}
