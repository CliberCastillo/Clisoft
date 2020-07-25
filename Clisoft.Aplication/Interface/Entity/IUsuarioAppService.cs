using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IUsuarioAppService : IBaseAppService<UsuarioDTO,Usuario>
    {
        string GenerarCodigo();
        Task<bool> ValidarInicioSesionAsync(string usuario, string contraseña);
    }
}
