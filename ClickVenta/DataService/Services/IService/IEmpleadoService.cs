using BusinessEntities.Dtos.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IEmpleadoService
    {
        Task<string> CreateEmpleado(CreateEmpleadoDto empleadoDto);
        Task<string> UpdateEmpleado(UpdateEmpleadoDto empleadoDto);
        Task<string> DeleteEmpleado(DeleteEmpleadoDto empleadoDto);
        Task<IEnumerable<EmpleadoDto>> GetAllEmpleados(int state, int page, int pageSize, string filter = null);
        Task<EmpleadoDto> GetEmpleadoById(string id);
    }
}
