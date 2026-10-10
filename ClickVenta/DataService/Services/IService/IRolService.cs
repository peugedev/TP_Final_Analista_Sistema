using BusinessEntities.Dtos.Rol;

namespace DataService.Services.IService
{
    public interface IRolService
    {
        Task<string> CreateRol(CreateRolDto rolDto);
        Task<string> UpdateRol(UpdateRolDto rolDto);
        Task<string> DeleteRol(DeleteRolDto rolDto);
        Task<IEnumerable<RolDto>> GetAllRoles(int state, int page, int pageSize, string filter = null);
        Task<RolDto> GetRolById(string id);
    }
}
