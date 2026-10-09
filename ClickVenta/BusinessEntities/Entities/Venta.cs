using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Venta: BaseEntity
    {
        public int IdUsuario{ get; set; }
        public int NroTicket { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }
        public List<DetallePago> DetallesPago { get; set; } = new List<DetallePago>();
        public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
    }
}
