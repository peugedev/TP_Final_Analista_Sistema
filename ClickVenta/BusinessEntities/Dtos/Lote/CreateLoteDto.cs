using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Lote
{
    public class CreateLoteDto : BaseDto
    {
        public string ProductoId { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Stock { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
    }
}
