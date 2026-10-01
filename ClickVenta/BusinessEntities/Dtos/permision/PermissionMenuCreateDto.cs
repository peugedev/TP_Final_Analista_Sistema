using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Dtos.permision
{
    public class PermissionMenuCreateDto
    {
        public string UsuarioId { get; set; }
        public string SubMenuId { get; set; }
        public string MenuId { get; set; }

    }
}
