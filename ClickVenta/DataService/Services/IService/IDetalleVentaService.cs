using System;
using BusinessEntities.Dtos.DetalleVenta;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IDetalleVentaService
    {
        Task<string> CreateDetalleVenta(CreateDetalleVentaDto detalleVentaDto);
        Task<string> UpdateDetalleVenta(UpdateDetalleVentaDto detalleVentaDto);
        Task<string> DeleteDetalleVenta(DeleteDetalleVentaDto detalleVentaDto);
        Task<IEnumerable<DetalleVentaDto>> GetAllDetalleVentas(int state, int page, int pageSize, string filter = null);
        Task<DetalleVentaDto> GetDetalleVentaById(string id);
    }
}
