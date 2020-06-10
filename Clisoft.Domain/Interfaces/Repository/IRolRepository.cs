using Clisoft.Domain.Entities;
using System.Collections.Generic;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IRolRepository : IEFRepository<Rol>
    {
        List<Rol> role();
    }
}
