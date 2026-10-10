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
    public class LoteRepository : ILoteRepository
    {
        private readonly IGenericRepository<Lote> _genericRepository;
        public LoteRepository(IGenericRepository<Lote> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public async Task<Lote> Create(string query, SqlParameter[] parameters)
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
        public Task<IEnumerable<Lote>> GetAll(string query, SqlParameter[] parameters)
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
        public async Task<Lote> GetById(string query, SqlParameter[] parameters)
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
        public async Task<Lote> Update(string query, SqlParameter[] parameters)
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
