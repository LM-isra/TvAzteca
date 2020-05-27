using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TvAzteca.Core.Entities;
using TvAzteca.Core.Repositories;

namespace TvAzteca.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Usuario>> GetAllWithUsuario()
        {
            return await AppDbContext.Usuarios
                .ToListAsync();
        }

        public Task<Usuario> GetWithUsuarioById(int id)
        {
            return AppDbContext.Usuarios
                .SingleOrDefaultAsync(a => a.UsuarioId == id);
        }
         
        private AppDbContext AppDbContext
        {
            get { return Context as AppDbContext; }
        }
    }
}
