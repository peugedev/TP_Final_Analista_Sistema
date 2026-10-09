using System;
using AutoMapper;
using BusinessEntities.Dtos.DetalleVenta;
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
    public class DetalleVentaService : IDetalleVentaService
    {
        private readonly IDetalleVentaRepository _detalleVentaRepository;
        private readonly IMapper _mapper;

        public DetalleVentaService(IDetalleVentaRepository detalleVentaRepository, IMapper mapper)
        {
            _detalleVentaRepository = detalleVentaRepository;
            _mapper = mapper;
        }

        public async Task<string> CreateDetalleVenta(CreateDetalleVentaDto detalleVentaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ProductoId", detalleVentaDto.ProductoId),
                    new SqlParameter("@VentaId", detalleVentaDto.VentaId),
                    new SqlParameter("@Cantidad", detalleVentaDto.Cantidad),
                    new SqlParameter("@Precio", detalleVentaDto.Precio),
                    new SqlParameter("@SubTotal", detalleVentaDto.Subtotal)
                };

                var detalle = _mapper.Map<BusinessEntities.Entities.DetalleVenta>(detalleVentaDto);
                await this._detalleVentaRepository.Create("[dbo].[Sp_InsertDetalleVenta]", parameters);
                return "Detalle de venta creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeleteDetalleVenta(DeleteDetalleVentaDto detalleVentaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", detalleVentaDto.Id)
                };
                await this._detalleVentaRepository.Delete("[dbo].[Sp_DeleteDetalleVenta]", parameters);
                return "Detalle de venta eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<DetalleVentaDto>> GetAllDetalleVentas(int state, int page, int pageSize, string filter = null)
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
                var detalles = await this._detalleVentaRepository.GetAll("[dbo].[Sp_GetAllDetalleVentas]", parameters);
                return _mapper.Map<IEnumerable<DetalleVentaDto>>(detalles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<DetalleVentaDto> GetDetalleVentaById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var detalle = await this._detalleVentaRepository.GetById("[dbo].[Sp_GetDetalleVentaById]", parameters);
                return _mapper.Map<DetalleVentaDto>(detalle);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdateDetalleVenta(UpdateDetalleVentaDto detalleVentaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", detalleVentaDto.Id),
                    new SqlParameter("@ProductoId", detalleVentaDto.ProductoId),
                    new SqlParameter("@VentaId", detalleVentaDto.VentaId),
                    new SqlParameter("@Cantidad", detalleVentaDto.Cantidad),
                    new SqlParameter("@Precio", detalleVentaDto.Precio),
                    new SqlParameter("@SubTotal", detalleVentaDto.Subtotal)
                };

                var detalle = _mapper.Map<BusinessEntities.Entities.DetalleVenta>(detalleVentaDto);
                await this._detalleVentaRepository.Update("[dbo].[Sp_UpdateDetalleVenta]", parameters);
                return "Detalle de venta actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
