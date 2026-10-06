using AutoMapper;
using BusinessEntities.Dtos.Producto;
using BusinessEntities.Dtos.TiposMovimiento;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;

namespace DataService.Services.Service
{
    public class TipoMovimientoService : ITipoMovimientoService
    {
        private readonly ITipoMovimientoRepository _TipoMovimientoRepository;
        private readonly IMapper _mapper;

        public TipoMovimientoService(ITipoMovimientoRepository TipoMovimientoRepository, IMapper mapper)
        {
            _TipoMovimientoRepository = TipoMovimientoRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateTipoMovimiento(CreateTipoMovimientoDto tipoMovimientoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", tipoMovimientoDto.Descripcion),
                    new SqlParameter("@Nombre", tipoMovimientoDto.Nombre),
                };
                var tipoMovimiento = _mapper.Map<BusinessEntities.Entities.TipoMovimiento>(tipoMovimientoDto);
                await this._TipoMovimientoRepository.Create("[dbo].[Sp_InsertTipoMovimiento]", parameters);
                return "TipoMovimiento creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteTipoMovimiento(DeleteTipoMovimientoDto tipoMovimientoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", tipoMovimientoDto.Id)
                };
                await this._TipoMovimientoRepository.Delete("[dbo].[Sp_DeleteTipoMovimiento]", parameters);
                return "TipoMovimiento eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<TipoMovimientoDto>> GetAllTipoMovimientos(int state, int page, int pageSize, string filter = null)
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
                var tipoMovimientos = await this._TipoMovimientoRepository.GetAll("[dbo].[Sp_GetAllTipoMovimientos]", parameters);
                return _mapper.Map<IEnumerable<TipoMovimientoDto>>(tipoMovimientos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<TipoMovimientoDto> GetTipoMovimientoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var tipoMovimiento = await this._TipoMovimientoRepository.GetById("[dbo].[Sp_GetTipoMovimientoById]", parameters);
                return _mapper.Map<TipoMovimientoDto>(tipoMovimiento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateTipoMovimiento(UpdateTipoMovimientoDto tipoMovimientoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", tipoMovimientoDto.Descripcion),
                    new SqlParameter("@Nombre", tipoMovimientoDto.Nombre),
                };
                var tipoMovimiento = _mapper.Map<BusinessEntities.Entities.TipoMovimiento>(tipoMovimientoDto);
                await this._TipoMovimientoRepository.Update("[dbo].[Sp_UpdateTipoMovimiento]", parameters);
                return "TipoMovimiento actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
