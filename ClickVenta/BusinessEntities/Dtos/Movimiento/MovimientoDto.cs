using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Movimiento
{
    public class MovimientoDTO : BaseDto
    {
        public string TipoMovimientoId { get; set; }
        public string TipoMovimientoNombre { get; set; }
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
    }
}
