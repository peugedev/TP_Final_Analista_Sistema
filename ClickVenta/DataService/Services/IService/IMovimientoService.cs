using BusinessEntities.Dtos.Empleado;
using BusinessEntities.Dtos.Movimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IMovimientoService
    {
        Task<string> CreateMovimiento(CreateMovimientoDto movimientoDto);
        Task<string> UpdateMovimiento(UpdateMovimientoDto movimientoDto);
        Task<string> DeleteMovimiento(DeleteMovimientoDto movimientoDto);
        Task<IEnumerable<MovimientoDTO>> GetAllMovimientos(int state, int page, int pageSize, string filter = null);
        Task<MovimientoDTO> GetMovimientoById(string id);
    }
}
