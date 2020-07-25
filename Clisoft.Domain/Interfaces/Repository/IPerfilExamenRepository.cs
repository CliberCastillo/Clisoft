using Clisoft.Domain.Entities;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IPerfilExamenRepository : IGenericRepository<PerfilExamen>
    {
        string GenerarCodigo();
    }
}
