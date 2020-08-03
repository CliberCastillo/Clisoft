using Clisoft.Domain.Entities;
using Clisoft.Domain.Helper;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        string GenerarCodigo();
        Task<ClienteUsuario> NombreCorreoClienteAsync(string usuario, string contraseña);
    }
}
