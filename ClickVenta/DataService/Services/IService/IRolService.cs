using BusinessEntities.Dtos.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IRolService
    {
        Task<string> CreateRol(CreateRolDto rolDto);
        Task<string> UpdateRol(UpdateRolDto rolDto);
        Task<string> DeleteRol(DeleteRolDto rolDto);
        Task<IEnumerable<RolDto>> GetAllRoles(int state, int page, int pageSize, string filter = null);
        Task<RolDto> GetRolById(string id);
        Task<string> CreateRolA(CrearRolDto rol);
        Task<string> UpdateRol(UpdateRolDto rol);
        Task<bool> DeleteRol(EliminarRodDto id);
    }
}
