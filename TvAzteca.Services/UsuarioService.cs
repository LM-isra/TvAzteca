using System.Collections.Generic;
using System.Threading.Tasks;
using TvAzteca.Core;
using TvAzteca.Core.Entities;
using TvAzteca.Core.Services;

namespace TvAzteca.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuarioService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public async Task<Usuario> CreateUsuario(Usuario newUsuario)
        {
            await _unitOfWork.Usuarios.AddAsync(newUsuario);
            await _unitOfWork.CommitAsync();
            return newUsuario;
        }

        public async Task DeleteUsuario(Usuario Usuario)
        {
            _unitOfWork.Usuarios.Remove(Usuario);
            await _unitOfWork.CommitAsync();
        }

        public Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
            throw new System.NotImplementedException();
        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await _unitOfWork.Usuarios.GetWithUsuarioById(id);
        }

        public async Task UpdateUsuario(Usuario UsuarioToBeUpdated, Usuario Usuario)
        {
            UsuarioToBeUpdated.Nombre = Usuario.Nombre;

            await _unitOfWork.CommitAsync();
        }
    }
}
