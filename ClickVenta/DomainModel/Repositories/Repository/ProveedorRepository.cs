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
    public class ProveedorRepository: GenericRepository<Proveedor>, IProveedorRepository
    {
        private readonly IGenericRepository<Proveedor> _genericRepository;
        public ProveedorRepository(IGenericRepository<Proveedor> genericRepository, ISqlConnectionFactory factory):base(factory)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Proveedor> Create(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public Task<IEnumerable<Proveedor>> GetAll(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public async Task<Proveedor> GetById(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
        public async Task<Proveedor> Update(string query, SqlParameter[] parameters,CancellationToken ct = default)
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
