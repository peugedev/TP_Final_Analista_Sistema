using AutoMapper;
using BusinessEntities.Dtos.Usuario;
using DataService.Services.IService;
using DomainModel.Repositories.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Resolver.Security.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public async Task<string> Add(CrearUsuarioDto be)
        {
            try
            {
               
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@EmpleadoId", be.EmpleadoId),
                    new SqlParameter("@RolId", be.RolId),
                    new SqlParameter("@NombreUsuario", be.NombreUsuario),
                    new SqlParameter("@Contrasena", PasswordEncryptor.GetInstance().Encypt(be.Contrasena))
                };
                await _usuarioRepository.Create("sp_CreateUsuario", parameters);
                return "Usuario creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> Delete(EliminarUsuario usr)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", usr.id)
                };
                await _usuarioRepository.Delete("sp_DeleteUsuario", sqlParameters);
                return "Usuario eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Usuarios>> GetAll(int state, int page, int pageSize, string filter = null)
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
                var result = await _usuarioRepository.GetAll("sp_GetAllUsuarios", sqlParameters);
                return _mapper.Map<IEnumerable<Usuarios>>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> GetById(string Id)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", Id)
                };
                var result = await _usuarioRepository.GetById("sp_GetUsuarioById", sqlParameters);
                return _mapper.Map<Usuario>(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> Update(ActualizarUsuario be)
        {
            try
            {     
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@EmpleadoId", be.EmpleadoId),
                    new SqlParameter("@RolId", be.RolId),
                    new SqlParameter("@Contrasena", PasswordEncryptor.GetInstance().Encypt(be.Contrasena))
                };
                await _usuarioRepository.Update("sp_UpdateUsuario", sqlParameters);
                return "Usuario actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
