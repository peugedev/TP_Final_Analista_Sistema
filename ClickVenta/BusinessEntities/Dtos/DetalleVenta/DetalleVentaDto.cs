using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.DetalleVenta
{
    public class DetalleVentaDto : BaseDto
    {
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
    }
}
