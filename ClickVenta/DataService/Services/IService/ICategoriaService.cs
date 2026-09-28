using BusinessEntities.Dtos.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface ICategoriaService
    {
        Task<string> CreateCategoria(CreateCategoriaDto categoriaDto);
        Task<string> UpdateCategoria(UpdateCategoriaDto categoriaDto);
        Task<string> DeleteCategoria(DeleteCategoriaDto categoriaDto);
        Task<IEnumerable<CategoriaDto>> GetAllCategorias(int state, int page, int pageSize, string filter = null);
        Task<CategoriaDto> GetCategoriaById(string id);
    }
}
