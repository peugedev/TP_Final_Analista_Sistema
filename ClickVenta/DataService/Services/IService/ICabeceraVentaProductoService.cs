using BusinessEntities.Dtos;
using BusinessEntities.Dtos.Cabecera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface ICabeceraVentaProductoService
    {
        Task<CabeceraVentaDto> GetCabecera();
        Task<ConsultaProductoCodigoBarraDto> ConsultaProductoCodigo(string codigo);
    }
}
