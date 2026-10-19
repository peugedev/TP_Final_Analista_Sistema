using System;
using BusinessEntities.Entities;
using DomainModel.GenericRepository.IGeneric;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.GenericRepository.Generic;
using DomainModel.Connection.Data.Abstractions;

namespace DomainModel.Repositories.Repository
{
    public class VentaRepository : GenericRepository<Venta>, IVentaRepository
    {
        private readonly IGenericRepository<Venta> _genericRepository;
        public VentaRepository(IGenericRepository<Venta> genericRepository, ISqlConnectionFactory factory):base(factory)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Venta> Create(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public async Task<bool> Delete(string query, SqlParameter[] parameters,CancellationToken ct = default)
        {
            try
            {
                return await this._genericRepository.Delete(query, parameters, ct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Task<IEnumerable<Venta>> GetAll(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public async Task<Venta> GetById(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public async Task<Venta> Update(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
