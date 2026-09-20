using DomainModel.Connection;
using DomainModel.GenericRepository.IGeneric;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.GenericRepository.Generic
{
    public class GenericRepository<Entitty> : ConnectionSQL, IGenericRepository<Entitty> where Entitty : class
    {
        public GenericRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public Task<Entitty> Create(string query, SqlParameter[] parameters)
        {
            try
            {
                ExecuteNonQuery(query, parameters);
                return Task.FromResult<Entitty>(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> Delete(string query, SqlParameter[] parameters)
        {
            try
            {
                ExecuteNonQuery(query, parameters);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<IEnumerable<Entitty>> GetAll(string query, SqlParameter[] parameters)
        {
            List<Entitty> entities = new List<Entitty>();
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        if (parameters is not null && parameters.Length > 0)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.CommandText = query;
                        command.CommandType = CommandType.StoredProcedure;

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Entitty entity = Activator.CreateInstance<Entitty>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    var property = typeof(Entitty).GetProperty(reader.GetName(i));
                                    if (property != null && !reader.IsDBNull(i))
                                    {
                                        property.SetValue(entity, reader.GetValue(i));
                                    }
                                }
                                entities.Add(entity);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CloseConnection(connection);
                    throw ex;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
            return Task.FromResult<IEnumerable<Entitty>>(entities);
        }

        public Task<Entitty> GetById(string query, SqlParameter[] parameters)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                try
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        if (parameters is not null && parameters.Length > 0)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.CommandText = query;
                        command.CommandType = CommandType.StoredProcedure;

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Entitty entity = Activator.CreateInstance<Entitty>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    var property = typeof(Entitty).GetProperty(reader.GetName(i));
                                    if (property != null && !reader.IsDBNull(i))
                                    {
                                        property.SetValue(entity, reader.GetValue(i));
                                    }
                                }
                                return Task.FromResult<Entitty>(entity);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CloseConnection(connection);
                    throw ex;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
            return Task.FromResult<Entitty>(null);  
        }

        public Task<Entitty> Update(string query, SqlParameter[] parameters)
        {
            try
            {
                ExecuteNonQuery(query, parameters);
                return Task.FromResult<Entitty>(null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        if (parameters is not null && parameters.Length > 0)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        command.CommandText = query;
                        command.CommandType = CommandType.StoredProcedure;
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    CloseConnection(connection);
                    throw ex;
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
        }
    }
}
