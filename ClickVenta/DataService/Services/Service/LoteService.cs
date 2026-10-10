using AutoMapper;
using BusinessEntities.Dtos.Lote;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.Service
{
    public class LoteService : ILoteService
    {
        private readonly ILoteRepository _loteRepository;
        private readonly IMapper _mapper;

        public LoteService(ILoteRepository loteRepository, IMapper mapper)
        {
            _loteRepository = loteRepository;
            _mapper = mapper;
        }

        public async Task<string> CreateLote(CreateLoteDto loteDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ProductoId", loteDto.ProductoId),
                    new SqlParameter("@FechaVencimiento", loteDto.FechaVencimiento),
                    new SqlParameter("@Stock", loteDto.Stock),
                    new SqlParameter("@PrecioVenta", loteDto.PrecioVenta),
                    new SqlParameter("@PrecioCompra", loteDto.PrecioCompra)
                };

                var entity = _mapper.Map<BusinessEntities.Entities.Lote>(loteDto);
                await this._loteRepository.Create("[dbo].[Sp_InsertLote]", parameters);
                return "Lote creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeleteLote(DeleteLoteDto loteDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", loteDto.Id)
                };
                await this._loteRepository.Delete("[dbo].[Sp_DeleteLote]", parameters);
                return "Lote eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<LoteDto>> GetAllLotes(int state, int page, int pageSize, string filter = null)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@State", state),
                    new SqlParameter("@Page", page),
                    new SqlParameter("@PageSize", pageSize),
                    new SqlParameter("@Filter", filter ?? (object)DBNull.Value)
                };
                var items = await this._loteRepository.GetAll("[dbo].[Sp_GetAllLotes]", parameters);
                return _mapper.Map<IEnumerable<LoteDto>>(items);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<LoteDto> GetLoteById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var item = await this._loteRepository.GetById("[dbo].[Sp_GetLoteById]", parameters);
                return _mapper.Map<LoteDto>(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdateLote(UpdateLoteDto loteDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", loteDto.Id),
                    new SqlParameter("@ProductoId", loteDto.ProductoId),
                    new SqlParameter("@FechaVencimiento", loteDto.FechaVencimiento),
                    new SqlParameter("@Stock", loteDto.Stock),
                    new SqlParameter("@PrecioVenta", loteDto.PrecioVenta),
                    new SqlParameter("@PrecioCompra", loteDto.PrecioCompra)
                };

                var entity = _mapper.Map<BusinessEntities.Entities.Lote>(loteDto);
                await this._loteRepository.Update("[dbo].[Sp_UpdateLote]", parameters);
                return "Lote actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
