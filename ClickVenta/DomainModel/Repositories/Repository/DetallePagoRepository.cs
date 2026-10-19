using BusinessEntities.Entities;
using DomainModel.Connection.Data.Abstractions;
using DomainModel.GenericRepository.Generic;
using DomainModel.GenericRepository.IGeneric;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;

namespace DomainModel.Repositories.Repository
{
    public class DetallePagoRepository : GenericRepository<DetallePago>, IDetallePagoRepository
    {
        private readonly IGenericRepository<DetallePago> _genericRepository;
        public DetallePagoRepository(IGenericRepository<DetallePago> genericRepository, ISqlConnectionFactory factory):base(factory)
        {
            _genericRepository = genericRepository;
        }
        public async Task<DetallePago> Create(string query, SqlParameter[] parameters, CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.Create(query, parameters, ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> Delete(string query, SqlParameter[] parameters, CancellationToken ct = default)
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
        public Task<IEnumerable<DetallePago>> GetAll(string query, SqlParameter[] parameters, CancellationToken ct = default)
        {
            try
            {
                return this._genericRepository.GetAll(query, parameters, ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<DetallePago> GetById(string query, SqlParameter[] parameters, CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.GetById(query, parameters, ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<DetallePago> Update(string query, SqlParameter[] parameters, CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.Update(query, parameters, ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
