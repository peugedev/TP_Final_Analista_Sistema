using BusinessEntities.Dtos.ProveedorProducto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IProveedorProductoService
    {
        Task<string> CreateProveedorProducto(CreateProveedorProductoDto dto);
        Task<string> UpdateProveedorProducto(UpdateProveedorProductoDto dto);
        Task<string> DeleteProveedorProducto(DeleteProveedorProductoDto dto);
        Task<IEnumerable<ProveedorProductoDto>> GetAllProveedorProductos(int state, int page, int pageSize, string filter = null);
        Task<ProveedorProductoDto> GetProveedorProductoById(string id);
    }
}
