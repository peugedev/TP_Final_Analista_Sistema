using AutoMapper;
using BusinessEntities.Dtos.Rol;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;

namespace DataService.Services.Service
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        private readonly IMapper _mapper;

        public RolService(IRolRepository rolRepository, IMapper mapper)
        {
            _rolRepository = rolRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateRol(CreateRolDto productoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", productoDto.Descripcion),
                    new SqlParameter("@Nombre", productoDto.Nombre)
                };
                var producto = _mapper.Map<BusinessEntities.Entities.Rol>(productoDto);
                await this._rolRepository.Create("[dbo].[Sp_InsertRol]", parameters);
                return "Rol creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteRol(DeleteRolDto rolDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", rolDto.Id)
                };
                await this._rolRepository.Delete("[dbo].[Sp_DeleteRol]", parameters);
                return "Rol eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IEnumerable<RolDto>> GetAllRoles(int state, int page, int pageSize, string filter = null)
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
                var roles = await this._rolRepository.GetAll("[dbo].[Sp_GetAllRoles]", parameters);
                return _mapper.Map<IEnumerable<RolDto>>(roles);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<RolDto> GetRolById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var rol = await this._rolRepository.GetById("[dbo].[Sp_GetRolById]", parameters);
                return _mapper.Map<RolDto>(rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> UpdateRol(UpdateRolDto rolDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Descripcion", rolDto.Descripcion),
                    new SqlParameter("@Nombre", rolDto.Nombre)
                };
                var rol = _mapper.Map<BusinessEntities.Entities.Rol>(rolDto);
                await this._rolRepository.Update("[dbo].[Sp_UpdateRol]", parameters);
                return "Rol actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
