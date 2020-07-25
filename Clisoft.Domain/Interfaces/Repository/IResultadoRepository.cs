using Clisoft.Domain.Entities;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IResultadoRepository : IGenericRepository<Resultado>
    {
        string GenerarCodigo();
    }
}
