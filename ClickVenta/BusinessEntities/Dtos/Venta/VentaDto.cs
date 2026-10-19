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
        public string? UsuarioId { get; set; }
        public string NroTicket { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }


        /* Detalle venta */
        public string ProductoId { get; set; }
        public string VentaId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }

        //public List<DetalleVentaDto> DetallesVenta { get; set; } = new List<DetalleVentaDto>();
    }
}
