using AutoMapper;
using BusinessEntities.Dtos.Movimiento;
using BusinessEntities.Dtos.Producto;
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
    public class MovimientoService : IMovimientoService
    {
        private readonly IMovimientoRepository _movimientoRepository;
        private readonly IMapper _mapper;

        public MovimientoService(IMovimientoRepository movimientoRepository, IMapper mapper)
        {
            _movimientoRepository = movimientoRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateMovimiento(CreateMovimientoDto movimientoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", movimientoDto.Descripcion),
                    new SqlParameter("@Nombre", movimientoDto.Nombre),
                    new SqlParameter("@Monto", movimientoDto.Monto),
                    new SqlParameter("@TipoMovimientoId", movimientoDto.TipoMovimientoId)
                };
                var movimiento = _mapper.Map<BusinessEntities.Entities.Movimiento>(movimientoDto);
                await this._movimientoRepository.Create("[dbo].[Sp_InsertMovimiento]", parameters);
                return "Movimiento creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteMovimiento(DeleteMovimientoDto movimientoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", movimientoDto.Id)
                };
                await this._movimientoRepository.Delete("[dbo].[Sp_DeleteMovimiento]", parameters);
                return "Movimiento eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<MovimientoDTO>> GetAllMovimientos(int state, int page, int pageSize, string filter = null)
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
                var movimientos = await this._movimientoRepository.GetAll("[dbo].[Sp_GetAllMovimientos]", parameters);
                return _mapper.Map<IEnumerable<MovimientoDTO>>(movimientos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MovimientoDTO> GetMovimientoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var movimiento = await this._movimientoRepository.GetById("[dbo].[Sp_GetMovimientoById]", parameters);
                return _mapper.Map<MovimientoDTO>(movimiento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateMovimiento(UpdateMovimientoDto movimientoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", movimientoDto.Descripcion),
                    new SqlParameter("@Nombre", movimientoDto.Nombre),
                    new SqlParameter("@Monto", movimientoDto.Monto),
                    new SqlParameter("@TipoMovimientoId", movimientoDto.TipoMovimientoId)
                };
                var movimiento = _mapper.Map<BusinessEntities.Entities.Movimiento>(movimientoDto);
                await this._movimientoRepository.Update("[dbo].[Sp_UpdateMovimiento]", parameters);
                return "Movimiento actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
