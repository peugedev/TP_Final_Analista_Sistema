using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class Venta: BaseEntity
    {
        // Usuario Id can be null
        public string? IdUsuario{ get; set; }
        public string NroTicket { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaVenta { get; set; }

        public Usuario? Usuario { get; set; }
        public List<DetallePago> DetallesPago { get; set; } = new List<DetallePago>();
        public List<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
    }
}
