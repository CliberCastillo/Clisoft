using Clisoft.Domain.Entities;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        string GenerarCodigo();
        Task<bool> ValidarInicioSesionAsync(string usuario, string contraseña);
    }
}
