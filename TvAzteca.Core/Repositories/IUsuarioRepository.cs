using System.Collections.Generic;
using System.Threading.Tasks;
using TvAzteca.Core.Entities;

namespace TvAzteca.Core.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> GetAllWithUsuario();
        Task<Usuario> GetWithUsuarioById(int id);
    }
}
