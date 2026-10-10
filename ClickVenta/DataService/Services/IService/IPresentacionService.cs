using BusinessEntities.Dtos.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IPresentacionService
    {
        Task<string> CreatePresentacion(CreatePresentacionDto presentacionDto);
        Task<string> UpdatePresentacion(UpdatePresentacionDto presentacionDto);
        Task<string> DeletePresentacion(DeletePresentacionDto presentacionDto);
        Task<IEnumerable<PresentacionDto>> GetAllPresentaciones(int state, int page, int pageSize, string filter = null);
        Task<PresentacionDto> GetPresentacionById(string id);
    }
}
