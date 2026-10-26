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
    public class CabeceraVentaRepository : GenericRepository<CabeceraVenta>, ICabeceraVentaRepository
    {
        private readonly IGenericRepository<CabeceraVenta> _genericRepository;
        public CabeceraVentaRepository(IGenericRepository<CabeceraVenta> genericRepository, ISqlConnectionFactory factory) : base(factory)
        {
            _genericRepository = genericRepository;
        }

        public async Task<CabeceraVenta> Create(string query, SqlParameter[] parameters, CancellationToken ct = default)
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

        public async Task<bool> Delete(string query, SqlParameter[] parameters, CancellationToken ct = default)
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

        public async Task<IEnumerable<CabeceraVenta>> GetAll(string query, SqlParameter[] parameters, CancellationToken ct = default)
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

        public async Task<CabeceraVenta> GetById(string query, SqlParameter[] parameters, CancellationToken ct = default)
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

        public async Task<CabeceraVenta> Update(string query, SqlParameter[] parameters, CancellationToken ct = default)
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
