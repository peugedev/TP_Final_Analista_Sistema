using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Venta
{
    public class CreateVentaDto : BaseDto
    {
        public string? IdUsuario { get; set; }
        public string NroTicket { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}