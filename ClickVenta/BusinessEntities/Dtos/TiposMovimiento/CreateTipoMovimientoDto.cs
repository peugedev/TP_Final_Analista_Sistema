using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.TiposMovimiento
{
    public class CreateTipoMovimientoDto : BaseDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
