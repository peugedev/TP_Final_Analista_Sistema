using BusinessEntities.Dtos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services.IService
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuarios>> GetAll(int state, int page, int pageSize, string filter = null);
        Task<Usuario> GetById(string Id);
        Task<string> Add(CrearUsuarioDto be);
        Task<string> Update(ActualizarUsuario be);
        Task<string> Delete(EliminarUsuario usr);
    }
}
