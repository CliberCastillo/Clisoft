using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IClienteAppService : IBaseAppService<ClienteDTO,Cliente>
    {
        string GenerarCodigo();
        Task<ClienteUsuarioDTO> NombreCorreoClienteAsync(string usuario, string contraseña);
    }
}
