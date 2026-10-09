using AutoMapper;
using BusinessEntities.Dtos.Empleado;
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
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        private readonly IMapper _mapper;

        public EmpleadoService(IEmpleadoRepository empleadoRepository, IMapper mapper)
        {
            _empleadoRepository = empleadoRepository;
            _mapper = mapper;
        }
        public async Task<string> CreateEmpleado(CreateEmpleadoDto empleadoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", empleadoDto.Nombre),
                    new SqlParameter("@Apellido", empleadoDto.Apellido),
                    new SqlParameter("@DNI", empleadoDto.DNI),
                    new SqlParameter("@Telefono", empleadoDto.Telefono),
                    new SqlParameter("@Direccion", empleadoDto.Direccion),
                    new SqlParameter("@RolId", empleadoDto.RolId),
                    new SqlParameter("@NombreUsuario", empleadoDto.NombreUsuario),
                    new SqlParameter("@Contrasena", PasswordEncryptor.GetInstance().Encypt(empleadoDto.Contrasena))
                };
                await this._empleadoRepository.Create("[dbo].[Sp_InsertEmpleado]", parameters);
                return "Empleado creado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeleteEmpleado(DeleteEmpleadoDto empleadoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", empleadoDto.Id)
                };
                await this._empleadoRepository.Delete("[dbo].[Sp_DeleteEmpleado]", parameters);
                return "Empleado eliminado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<EmpleadoDto>> GetAllEmpleados(int state, int page, int pageSize, string filter = null)
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
                var empleados = await this._empleadoRepository.GetAll("[dbo].[GetAllEmpleado]", parameters);
                
                return _mapper.Map<IEnumerable<EmpleadoDto>>(empleados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EmpleadoDto> GetEmpleadoById(string id)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };
                var empleado = await this._empleadoRepository.GetById("[dbo].[GetEmpleadoById]", parameters);
                return _mapper.Map<EmpleadoDto>(empleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> UpdateEmpleado(UpdateEmpleadoDto empleadoDto)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", empleadoDto.Id),
                    new SqlParameter("@DNI", empleadoDto.DNI),
                    new SqlParameter("@Nombre", empleadoDto.Nombre),
                    new SqlParameter("@Apellido", empleadoDto.Apellido),
                    new SqlParameter("@Telefono", empleadoDto.Telefono),
                    new SqlParameter("@Direccion", empleadoDto.Direccion)
                };
                await this._empleadoRepository.Update("[dbo].[Sp_UpdateEmpleado]", parameters);
                return "Empleado actualizado correctamente";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
