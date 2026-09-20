using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.GenericRepository.IGeneric
{
    public interface IGenericRepository <Entity> where Entity : class
    {
        Task<IEnumerable<Entity>> GetAll(string query, SqlParameter[] parameters);
        Task<Entity> GetById(string query, SqlParameter[] parameters);
        Task<Entity> Create(string query, SqlParameter[] parameters);
        Task<Entity> Update(string query, SqlParameter[] parameters);
        Task<bool> Delete(string query, SqlParameter[] parameters);
    }
}
