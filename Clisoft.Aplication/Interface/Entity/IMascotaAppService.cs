using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IMascotaAppService : IBaseAppService<MascotaDTO,Mascota>
    {
        string GenerarCodigo();
        Task<List<MascotaDTO>> ListadoDeMascotasPorClienteAsync(string usuario, string contraseña);
    }
}
