using AutoMapper;
using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Proveedor;
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
            //CreateMap<Empleado, CreateEmpleadoDto>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Empleado, UpdateEmpleadoDto>().ReverseMap();
            CreateMap<Empleado, DeleteEmpleadoDto>().ReverseMap();
            //CreateMap<BusinessEntities.Entities.Empleado, BusinessEntities.Dtos.Empleado.GetEmpleadoDto>().ReverseMap();
            //CreateMap<BusinessEntities.Entities.Empleado, BusinessEntities.Dtos.Empleado.GetAllEmpleadosDto>().ReverseMap();
            CreateMap<Proveedor, CreateProveedorDto>().ReverseMap().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Proveedor, UpdateProveedorDto>().ReverseMap();
            CreateMap<Proveedor, DeleteProveedorDto>().ReverseMap();
        }
    }
}
