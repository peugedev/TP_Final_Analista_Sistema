using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Empleado
{
    public class CreateEmpleadoDto : BaseDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumentoId { get; set; }

        // Additional properties specific to the creation of an employee can be added here

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
    }
}
