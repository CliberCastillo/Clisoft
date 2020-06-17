using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IRolRepository : IEFRepository<Rol>
    {
        Task<List<Rol>> buscarRolAsync(string id);
    }
}