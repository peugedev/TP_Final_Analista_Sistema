using BusinessEntities.Entities;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Task<Categoria> Create(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetAll(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetById(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> Update(string query, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
