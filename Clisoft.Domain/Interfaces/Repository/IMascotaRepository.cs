using Clisoft.Domain.Entities;
using System.Collections.Generic;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IMascotaRepository : IGenericRepository<Mascota>
    {
        string GenerarCodigo();
    }
}
