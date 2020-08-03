using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IMascotaRepository : IGenericRepository<Mascota>
    {
        string GenerarCodigo();
        Task<List<Mascota>> ListadoDeMascotasPorClienteAsync(string usuario, string contraseña);
    }
}
