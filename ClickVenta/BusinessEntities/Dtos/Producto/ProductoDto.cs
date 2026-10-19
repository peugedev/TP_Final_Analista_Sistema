using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Producto
{
    public class ProductoDto : BaseDto
    {
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string CategoriaId { get; set; }
        public string PresentacionId { get; set; }
        public string ProveedorProductoId { get; set; }
    }
}
