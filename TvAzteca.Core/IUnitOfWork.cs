using System;
using System.Threading.Tasks;
using TvAzteca.Core.Repositories;

namespace TvAzteca.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuarios { get; }
        Task<int> CommitAsync();
    }
}
