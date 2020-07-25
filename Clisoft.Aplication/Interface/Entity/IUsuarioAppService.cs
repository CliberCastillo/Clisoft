using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IUsuarioAppService : IBaseAppService<UsuarioDTO,Usuario>
    {
        string GenerarCodigo();
    }
}
