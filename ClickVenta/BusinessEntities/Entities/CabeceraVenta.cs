using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Entities
{
    public class CabeceraVenta
    {
        public string Id { get; set; }
        public string NroTicket { get; set; }
        public string total { get; set; }
        public string FormaPago { get; set; }
        public int Count { get; set; }

        /* Consulta producto para la venta */
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
