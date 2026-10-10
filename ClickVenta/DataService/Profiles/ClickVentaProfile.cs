using AutoMapper;
using BusinessEntities.Dtos.Categoria;
using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Login;
using BusinessEntities.Dtos.permision;
using BusinessEntities.Dtos.Rol;
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
            CreateMap<Empleado, CreateEmpleadoDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<BusinessEntities.Entities.Empleado, UpdateEmpleadoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
                        CreateMap<Empleado, DeleteEmpleadoDto>()

                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Empleado, EmpleadoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
                .ForMember(dest => dest.Telefono, opt => opt.MapFrom(src => src.Telefono))
                .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
                .ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Rol, CreateRolDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();
            CreateMap<Rol, UpdateRolDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();
            CreateMap<Rol, DeleteRolDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();

            CreateMap<Rol, RolDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
                .ReverseMap();

            CreateMap<Usuario, LoginReturnDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.EmpleadoId, opt => opt.MapFrom(src => src.EmpleadoId))
                .ForMember(dest => dest.NombreUsuario, opt => opt.MapFrom(src => src.NombreUsuario))
                .ForMember(dest => dest.RolId, opt => opt.MapFrom(src => src.RolId))
                .ReverseMap();
            CreateMap<PermissionMenu, PermissionMenuDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.SubMenuId, opt => opt.MapFrom(src => src.SubMenuId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.SubMenuName, opt => opt.MapFrom(src => src.SubMenuName))
                .ForMember(dest => dest.IsAssigned, opt => opt.MapFrom(src => src.IsAssigned))
                .ForMember(dest => dest.FormAssociation, opt => opt.MapFrom(src => src.formAssociation))
                .ReverseMap();
        }
    }
}
