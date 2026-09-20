using AutoMapper;
using BusinessEntities.Dtos.Empleado;
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
        }
    }
}
