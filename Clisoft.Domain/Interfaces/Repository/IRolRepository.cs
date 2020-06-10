using Clisoft.Domain.Entity;
using System.Collections.Generic;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IRolRepository : IEFRepository<Rol>
    {
        List<Rol> role();
    }
}
