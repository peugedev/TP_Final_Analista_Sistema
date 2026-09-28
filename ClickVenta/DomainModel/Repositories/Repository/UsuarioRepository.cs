using BusinessEntities.Entities;
using DomainModel.GenericRepository.IGeneric;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repositories.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IGenericRepository<Usuario> _genericRepository;

        public UsuarioRepository(IGenericRepository<Usuario> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Usuario> Create(string query, SqlParameter[] parameters)
        {
            try
            {
                return await this._genericRepository.Create(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(string query, SqlParameter[] parameters)
        {
            try
            {
                return await this._genericRepository.Delete(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll(string query, SqlParameter[] parameters)
        {
            try
            {
                return await this._genericRepository.GetAll(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> GetById(string query, SqlParameter[] parameters)
        {
            try
            {
                return await this._genericRepository.GetById(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> Update(string query, SqlParameter[] parameters)
        {
            try
            {
                return await this._genericRepository.Update(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
