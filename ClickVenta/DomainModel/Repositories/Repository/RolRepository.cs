using BusinessEntities.Entities;
using DomainModel.GenericRepository.IGeneric;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;

namespace DomainModel.Repositories.Repository
{
    public class RolRepository : IRolRepository
    {
        private readonly IGenericRepository<Rol> _genericRepository;

        public RolRepository(IGenericRepository<Rol> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Rol> Create(string query, SqlParameter[] parameters)
        {
            try
            {
                return await _genericRepository.Create(query, parameters);
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
                return await _genericRepository.Delete(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Rol>> GetAll(string query, SqlParameter[] parameters)
        {
            try
            {
                return await _genericRepository.GetAll(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Rol> GetById(string query, SqlParameter[] parameters)
        {
            try
            {
                return await _genericRepository.GetById(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Rol> Update(string query, SqlParameter[] parameters)
        {
            try
            {
                return await _genericRepository.Update(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
