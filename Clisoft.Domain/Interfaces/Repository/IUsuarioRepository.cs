using Clisoft.Domain.Entities;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        string GenerarCodigo();
    }
}
