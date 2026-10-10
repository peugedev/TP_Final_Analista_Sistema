using System;
using AutoMapper;
using BusinessEntities.Dtos.Venta;
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
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _ventaRepository;
        private readonly IMapper _mapper;

        public VentaService(IVentaRepository ventaRepository, IMapper mapper)
        {
            _ventaRepository = ventaRepository;
            _mapper = mapper;
        }

        public async Task<string> CreateVenta(CreateVentaDto ventaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", ventaDto.IdUsuario),
                    new SqlParameter("@NroTicket", ventaDto.NroTicket),
                    new SqlParameter("@Total", ventaDto.Total),
                    new SqlParameter("@FechaVenta", ventaDto.FechaVenta)
                };

                var venta = _mapper.Map<BusinessEntities.Entities.Venta>(ventaDto);
                await this._ventaRepository.Create("[dbo].[Sp_InsertVenta]", parameters);
                return "Venta creada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeleteVenta(DeleteVentaDto ventaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", ventaDto.Id)
                };
                await this._ventaRepository.Delete("[dbo].[Sp_DeleteVenta]", parameters);
                return "Venta eliminada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<VentaDto>> GetAllVentas(int state, int page, int pageSize, string filter = null)
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
                var ventas = await this._ventaRepository.GetAll("[dbo].[Sp_GetAllVentas]", parameters);
                return _mapper.Map<IEnumerable<VentaDto>>(ventas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<VentaDto> GetVentaById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var venta = await this._ventaRepository.GetById("[dbo].[Sp_GetVentaById]", parameters);
                return _mapper.Map<VentaDto>(venta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdateVenta(UpdateVentaDto ventaDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", ventaDto.Id),
                    new SqlParameter("@IdUsuario", ventaDto.IdUsuario),
                    new SqlParameter("@NroTicket", ventaDto.NroTicket),
                    new SqlParameter("@Total", ventaDto.Total),
                    new SqlParameter("@FechaVenta", ventaDto.FechaVenta)
                };

                var venta = _mapper.Map<BusinessEntities.Entities.Venta>(ventaDto);
                await this._ventaRepository.Update("[dbo].[Sp_UpdateVenta]", parameters);
                return "Venta actualizada correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
