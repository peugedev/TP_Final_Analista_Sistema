using BusinessEntities.Entities;
using DomainModel.Connection.Data.Abstractions;
using DomainModel.GenericRepository.Generic;
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
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        private readonly IGenericRepository<Rol> _genericRepository;

        public RolRepository(IGenericRepository<Rol> genericRepository, ISqlConnectionFactory factory):base(factory)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Rol> Create(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.Create(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.Delete(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Rol>> GetAll(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await _genericRepository.GetAll(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Rol> GetById(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await _genericRepository.GetById(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Rol> Update(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await _genericRepository.Update(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
