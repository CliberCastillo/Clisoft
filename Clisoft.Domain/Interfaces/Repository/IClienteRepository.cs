using Clisoft.Domain.Entities;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        string GenerarCodigo();
    }
}
