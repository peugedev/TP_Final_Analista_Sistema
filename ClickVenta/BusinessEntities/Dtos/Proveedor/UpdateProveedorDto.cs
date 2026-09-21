using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.Proveedor
{
    public  class UpdateProveedorDto: BaseDto
    {
        public string Codigo { get; set; }
        public string Cuit_Cuil { get; set; }
        public string RazonSocial { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Web { get; set; }
    }
}
