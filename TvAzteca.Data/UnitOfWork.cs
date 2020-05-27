using System.Threading.Tasks;
using TvAzteca.Core;
using TvAzteca.Core.Repositories;
using TvAzteca.Data.Repositories;

namespace TvAzteca.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private UsuarioRepository _musicRepository;

        public UnitOfWork(AppDbContext context) => _context = context;
        

        public IUsuarioRepository Usuarios => _musicRepository = _musicRepository ?? new UsuarioRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
