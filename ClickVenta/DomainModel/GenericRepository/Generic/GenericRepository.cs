using DomainModel.Connection;
using DomainModel.GenericRepository.IGeneric;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Resolver.HelperError.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
                            entities = MapearReader(reader);
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
                            var entity = MapearReader(reader);
                            return Task.FromResult<Entitty>(entity?.FirstOrDefault());
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
        #region Private method convert

        private List<Entitty> MapearReader(IDataReader reader)
        {
            var lista = new List<Entitty>();

            // Cacheo de propiedades (incluye herencia)
            var propiedades = typeof(Entitty).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Diccionario case-insensitive + alias
            var mapaPropiedades = new Dictionary<string, PropertyInfo>(StringComparer.OrdinalIgnoreCase);
            foreach (var p in propiedades)
            {
                if (!mapaPropiedades.ContainsKey(p.Name))
                    mapaPropiedades.Add(p.Name, p);
            }

            // Cacheo de columnas del reader una sola vez
            int fieldCount = reader.FieldCount;
            var columnas = new string[fieldCount];
            for (int i = 0; i < fieldCount; i++)
                columnas[i] = reader.GetName(i);

            while (reader.Read())
            {
                Entitty entity = Activator.CreateInstance<Entitty>();

                for (int i = 0; i < fieldCount; i++)
                {
                    string columnName = columnas[i];

                    // 1) Buscar la propiedad (case-insensitive)
                    if (!mapaPropiedades.TryGetValue(columnName, out var property))
                    {
                        // 2) Fallback: ignorar guiones bajos ("id_rol" -> "IdRol")
                        string normalizado = columnName.Replace("_", "");
                        if (!mapaPropiedades.TryGetValue(normalizado, out property))
                            continue; // Columna no mapeada → se ignora silenciosamente
                    }

                    if (!property.CanWrite)
                        continue;

                    if (reader.IsDBNull(i))
                    {
                        // Si la propiedad es Nullable<Guid>, etc. se deja como null
                        continue;
                    }

                    try
                    {
                        object dbValue = reader.GetValue(i);
                        object? finalValue = ConvertirValor(dbValue, property.PropertyType);

                        if (finalValue != null)
                            property.SetValue(entity, finalValue);
                    }
                    catch (Exception ex)
                    {
                        // 🔥 Mensaje de diagnóstico REAL (antes solo decía "error al mapear")
                        throw new RepositoryException(
                            $"Error al mapear la columna '{columnName}' " +
                            $"(tipo BD: {reader.GetFieldType(i).Name}, valor: '{reader.GetValue(i)}') " +
                            $"a la propiedad '{property.Name}' ({property.PropertyType.Name}) " +
                            $"de la entidad '{typeof(Entitty).Name}'. Detalle: {ex.Message}",
                            ex);
                    }
                }

                lista.Add(entity);
            }

            return lista;
        }
        private static object? ConvertirValor(object dbValue, Type targetType)
        {
            if (dbValue == null || dbValue == DBNull.Value)
                return null;

            // Tipo real (si es Nullable<T>, sacamos el T)
            Type tipoDestino = Nullable.GetUnderlyingType(targetType) ?? targetType;

            // ---------- GUID / uniqueidentifier ----------
            if (tipoDestino == typeof(Guid))
            {
                switch (dbValue)
                {
                    case Guid g:
                        return g;

                    case string s when Guid.TryParse(s, out var gs):
                        return gs;

                    case byte[] bytes when bytes.Length == 16:
                        return new Guid(bytes);

                    // Por si el id en BD fuera int/bigint (autoincremental)
                    case int i:
                        return new Guid(i, 0, 0, new byte[8]);

                    case long l:
                        return new Guid((int)l, 0, 0, new byte[8]);
                }

                throw new InvalidCastException(
                    $"No se puede convertir '{dbValue}' ({dbValue.GetType().Name}) a Guid.");
            }

            // ---------- Si ya es del tipo correcto, devolverlo ----------
            if (tipoDestino.IsInstanceOfType(dbValue))
                return dbValue;

            // ---------- String ----------
            if (tipoDestino == typeof(string))
                return dbValue.ToString();

            // ---------- Enums ----------
            if (tipoDestino.IsEnum)
            {
                if (dbValue is string enumStr)
                    return Enum.Parse(tipoDestino, enumStr, ignoreCase: true);

                return Enum.ToObject(tipoDestino, dbValue);
            }

            // ---------- Booleanos desde bit/int ----------
            if (tipoDestino == typeof(bool))
            {
                if (dbValue is string bs)
                    return bool.Parse(bs);
                return Convert.ToBoolean(dbValue);
            }

            // ---------- DateTime ----------
            if (tipoDestino == typeof(DateTime))
            {
                if (dbValue is string ds)
                    return DateTime.Parse(ds, System.Globalization.CultureInfo.InvariantCulture);
                return Convert.ToDateTime(dbValue);
            }

            // ---------- Decimal / double / int, etc. ----------
            return Convert.ChangeType(dbValue, tipoDestino,
                System.Globalization.CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
