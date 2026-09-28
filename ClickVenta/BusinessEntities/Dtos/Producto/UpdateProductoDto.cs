using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Producto
{
    public class UpdateProductoDto
    {
        public string Descripcion { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public string IdCategoria { get; set; }
    }
}
