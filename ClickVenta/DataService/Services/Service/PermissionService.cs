using AutoMapper;
using BusinessEntities.Dtos.permision;
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
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionService(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }
        public async Task<PermissionMenuDto> Add(PermissionMenuCreateDto be)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@UserId", be.UsuarioId),
                    new SqlParameter("@SubMenuId", be.SubMenuId)
                };
                var result = await _permissionRepository.Create("sp_AddPermission", parameters);
                return _mapper.Map<PermissionMenuDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> Delete(string UserId, string SubMenuId)
        {
            try
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                     new SqlParameter("@UserId", UserId),
                    new SqlParameter("@SubMenuId", SubMenuId)
                };
                var result = await _permissionRepository.Delete("sp_UnassignPermission", parameter);
                return result ? "El permiso fue eliminado correctamente" : "El permiso no fue eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PermissionMenuDto>> GetAllMenusWithSubmenus()
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] { };
                var result = await _permissionRepository.GetAll("sp_GetAllMenusWithSubmenus", sqlParameters);
                return _mapper.Map<IEnumerable<PermissionMenuDto>>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<PermissionMenuDto>> GetUserPermissions(string UserId)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@UserId", UserId)
                };
                var result = await _permissionRepository.GetAll("sp_GetUserPermissions", sqlParameters);
                return _mapper.Map<IEnumerable<PermissionMenuDto>>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
