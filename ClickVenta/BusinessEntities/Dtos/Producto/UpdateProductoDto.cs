using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Producto
{
    public class UpdateProductoDto:BaseDto
    {
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; } = 0;
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public string CategoriaId { get; set; }
        public string PresentacionId { get; set; }
        public string ProveedorId { get; set; }
        public string ProveedorProductoId { get; set; }
        public DateTime? FechaVencimiento { get; set; }
    }
}
