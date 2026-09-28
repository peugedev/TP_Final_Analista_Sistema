using BusinessEntities.Dtos.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IProductoService
    {
        Task<string> CreateProducto(CreateProductoDto productoDto);
        Task<string> UpdateProducto(UpdateProductoDto productoDto);
        Task<string> DeleteProducto(DeleteProductoDto productoDto);
        Task<IEnumerable<ProductoDto>> GetAllProductos(int state, int page, int pageSize, string filter = null);
        Task<ProductoDto> GetProductoById(string id);
    }
}
