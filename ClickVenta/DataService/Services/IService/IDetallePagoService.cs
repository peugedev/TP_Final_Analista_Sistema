using BusinessEntities.Dtos.DetallePago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IDetallePagoService
    {
        Task<string> CreateDetallePago(CreateDetallePagoDto detallePagoDto);
        Task<string> UpdateDetallePago(UpdateDetallePagoDto detallePagoDto);
        Task<string> DeleteDetallePago(DeleteDetallePagoDto detallePagoDto);
        Task<IEnumerable<DetallePagoDto>> GetAllDetallePagos(int state, int page, int pageSize, string filter = null);
        Task<DetallePagoDto> GetDetallePagoById(string id);
    }
}
