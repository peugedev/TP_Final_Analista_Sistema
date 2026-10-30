using BusinessEntities.Dtos.DetalleVenta;
using BusinessEntities.Dtos.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IVentaService
    {
        Task<List<DetalleVentaDto>> CreateVenta(CreateVentaDto ventaDto);
        Task<string> UpdateVenta(UpdateVentaDto ventaDto);
        Task<string> DeleteVenta(DeleteVentaDto ventaDto);
        Task<IEnumerable<VentaDto>> GetAllVentas(int state, int page, int pageSize, string filter = null);
        Task<VentaDto> GetVentaById(string id);
    }
}
