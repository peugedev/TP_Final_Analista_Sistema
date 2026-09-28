using BusinessEntities.Dtos.permision;
using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IPermissionService
    {
        Task<PermissionMenuDto> Add(PermissionMenuDto be);
        Task<string> Delete(string UserId, string SubMenuId);
        Task<IEnumerable<PermissionMenuDto>> GetAllMenusWithSubmenus();
        Task<IEnumerable<PermissionMenuDto>> GetUserPermissions(string UserId);
    }
}
