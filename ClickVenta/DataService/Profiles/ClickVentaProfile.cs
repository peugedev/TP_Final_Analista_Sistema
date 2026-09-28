using AutoMapper;
using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.permision;
using BusinessEntities.Dtos.Usuario;
using BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Profiles
{
    public class ClickVentaProfile: Profile
    {
        public ClickVentaProfile()
        {
            #region Empleado
            CreateMap<Empleado, CreateEmpleadoDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
                .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.NumeroDocumento))
                .ForMember(dest => dest.TipoDocumentoId, opt => opt.MapFrom(src => src.TipoDocumentoId))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Empleado, UpdateEmpleadoDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
                .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.NumeroDocumento))
                .ForMember(dest => dest.TipoDocumentoId, opt => opt.MapFrom(src => src.TipoDocumentoId))
                .ReverseMap();

            CreateMap<Empleado, DeleteEmpleadoDto>()
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Empleado, BusinessEntities.Dtos.Empleado.EmpleadoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
                .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.NumeroDocumento))
                .ForMember(dest => dest.TipoDocumentoId, opt => opt.MapFrom(src => src.TipoDocumentoId))
                .ReverseMap();

            //CreateMap<BusinessEntities.Entities.Empleado, BusinessEntities.Dtos.Empleado.GetAllEmpleadosDto>().ReverseMap();

            #endregion

            //Permiso menu por usuario
            CreateMap<PermissionMenu, PermissionMenuDto>().ReverseMap();

            //Usuario
            CreateMap<BusinessEntities.Entities.Usuario, CrearUsuarioDto>()
                .ForMember(dest => dest.Contrasena, opt => opt.MapFrom(src => src.Contrasena))
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.EmpleadoId, opt => opt.MapFrom(src => src.EmpleadoId))
                .ForMember(dest => dest.RolId, opt => opt.MapFrom(src => src.RolId))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Usuario, ActualizarUsuario>()
                .ForMember(dest => dest.Contrasena, opt => opt.MapFrom(src => src.Contrasena))
                .ForMember(dest => dest.EmpleadoId, opt => opt.MapFrom(src => src.EmpleadoId))
                .ForMember(dest => dest.RolId, opt => opt.MapFrom(src => src.RolId))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Usuario, EliminarUsuario>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<BusinessEntities.Entities.Usuario, BusinessEntities.Dtos.Usuario.Usuario>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.EmpleadoId, opt => opt.MapFrom(src => src.EmpleadoId))
                .ForMember(dest => dest.RolId, opt => opt.MapFrom(src => src.RolId))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ReverseMap();

        }
    }
}
