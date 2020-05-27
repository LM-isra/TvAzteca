using System.Collections.Generic;
using System.Threading.Tasks;
using TvAzteca.Core.Entities;

namespace TvAzteca.Core.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> CreateUsuario(Usuario newUsuario);
        Task UpdateUsuario(Usuario UsuarioToBeUpdated, Usuario Usuario);
        Task DeleteUsuario(Usuario Usuario);
    }
}
