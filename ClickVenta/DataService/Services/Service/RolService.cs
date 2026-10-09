using AutoMapper;
using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Roles;
using BusinessEntities.Entities;
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
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        private readonly IMapper _mapper;

        public RolService(IRolRepository rolRepository, IMapper mapper)
        {
            _rolRepository = rolRepository;
            _mapper = mapper;
        }

        public async Task<string> CreateRolA(CrearRolDto rol)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", rol.Nombre),
                    new SqlParameter("@Descripcion", rol.Descripcion)
                };
                await this._rolRepository.Create("sp_CreateRol",parameters);
                return "Rol creado exitosamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteRol(EliminarRodDto id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id.Id)
                };
                await this._rolRepository.Delete("sp_DeleteRol", parameters);
                return true;
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
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@State", state),
                    new SqlParameter("@Page", page),
                    new SqlParameter("@PageSize", pageSize),
                    new SqlParameter("@Filter", filter ?? (object)DBNull.Value)
                };
                var result = await this._rolRepository.GetAll("sp_GetAllRoles", sqlParameters);
                //var rolesList = _mapper.Map<IEnumerable<RolDto>>(result);
                //return new RolesDto { Roles = rolesList.ToList() };
                return _mapper.Map<IEnumerable<RolDto>>(result);
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
                var result = await this._rolRepository.GetById("sp_GetRolById", parameters);
                return this._mapper.Map<RolDto>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdateRol(UpdateRolDto rol)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", rol.Id),
                    new SqlParameter("@Nombre", rol.Nombre),
                    new SqlParameter("@Descripcion", rol.Descripcion)
                };
                await this._rolRepository.Update("sp_UpdateRol", parameters);
                return "Rol actualizado exitosamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
