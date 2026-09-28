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
    public class ProductoRepository: IProductoRepository
    {
        private readonly IGenericRepository<Producto> _genericRepository;
        public ProductoRepository(IGenericRepository<Producto> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Producto> Create(string query, SqlParameter[] parameters)
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
        public Task<IEnumerable<Producto>> GetAll(string query, SqlParameter[] parameters)
        {
            try
            {
                return this._genericRepository.GetAll(query, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Producto> GetById(string query, SqlParameter[] parameters)
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
        public async Task<Producto> Update(string query, SqlParameter[] parameters)
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
