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
    public class TipoMovimientoRepository : GenericRepository<TipoMovimiento>, ITipoMovimientoRepository
    {
        private readonly IGenericRepository<TipoMovimiento> _genericRepository;
        public TipoMovimientoRepository(IGenericRepository<TipoMovimiento> genericRepository, ISqlConnectionFactory factory):base(factory)
        {
            _genericRepository = genericRepository;
        }
        public async Task<TipoMovimiento> Create(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public Task<IEnumerable<TipoMovimiento>> GetAll(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return this._genericRepository.GetAll(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<TipoMovimiento> GetById(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.GetById(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<TipoMovimiento> Update(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.Update(query, parameters,ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}