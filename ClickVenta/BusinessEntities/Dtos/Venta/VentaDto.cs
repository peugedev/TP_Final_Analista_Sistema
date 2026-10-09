using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Dtos.DetalleVenta;

namespace BusinessEntities.Dtos.Venta
{
    public class VentaDto : BaseDto
    {
        public int IdUsuario { get; set; }
        public string NroTicket { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
        public List<DetalleVentaDto> DetallesVenta { get; set; } = new List<DetalleVentaDto>();
    }
}
