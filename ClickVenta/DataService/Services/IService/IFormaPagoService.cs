using BusinessEntities.Dtos.FormaPago;
using BusinessEntities.Dtos.Movimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IFormaPagoService
    {
        Task<string> CreateFormaPago(CreateFormaPagoDto formaPagoDto);
        Task<string> UpdateFormaPago(UpdateFormaPagoDto formaPagoDto);
        Task<string> DeleteFormaPago(DeleteFormaPagoDto formaPagoDto);
        Task<IEnumerable<FormaPagoDto>> GetAllFormasPago(int state, int page, int pageSize, string filter = null);
        Task<FormaPagoDto> GetFormaPagoById(string id);
    }
}
