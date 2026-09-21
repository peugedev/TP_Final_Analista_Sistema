using BusinessEntities.Dtos.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IProveedorService
    {
        Task<string> CreateProveedor(CreateProveedorDto proveedorDto);
        Task<string> UpdateProveedor(UpdateProveedorDto proveedorDto);
        Task<string> DeleteProveedor(DeleteProveedorDto proveedorDto);
        Task<IEnumerable<ProveedorDto>> GetAllProveedores(int state, int page, int pageSize, string filter = null);
        Task<ProveedorDto> GetProveedorById(string id);
    }
}
