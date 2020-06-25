using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface ICargoRepository : IEFRepository<Cargo>
    {
        Task<List<Cargo>> buscarCargoAsync();
    }
}