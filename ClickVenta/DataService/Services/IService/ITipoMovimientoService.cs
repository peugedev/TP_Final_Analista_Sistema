using BusinessEntities.Dtos.TiposMovimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface ITipoMovimientoService
    {
        Task<string> CreateTipoMovimiento(CreateTipoMovimientoDto tipoMovimientoDto);
        Task<string> UpdateTipoMovimiento(UpdateTipoMovimientoDto tipoMovimientoDto);
        Task<string> DeleteTipoMovimiento(DeleteTipoMovimientoDto tipoMovimientoDto);
        Task<IEnumerable<TipoMovimientoDto>> GetAllTipoMovimientos(int state, int page, int pageSize, string filter = null);
        Task<TipoMovimientoDto> GetTipoMovimientoById(string id);
    }
}
