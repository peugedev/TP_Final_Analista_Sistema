using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.DetallePago
{
    public class DetallePagoDto: BaseDto
    {
        public int IdVenta { get; set; }
        public int IdFormaPago { get; set; }
        public string? Observaciones { get; set; }
    }
}
