using BusinessEntities.Dtos.Lote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface ILoteService
    {
        Task<string> CreateLote(CreateLoteDto loteDto);
        Task<string> UpdateLote(UpdateLoteDto loteDto);
        Task<string> DeleteLote(DeleteLoteDto loteDto);
        Task<IEnumerable<LoteDto>> GetAllLotes(int state, int page, int pageSize, string filter = null);
        Task<LoteDto> GetLoteById(string id);
    }
}
