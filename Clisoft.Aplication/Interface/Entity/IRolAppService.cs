using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IRolAppService : IBaseAppService<RolDTO, Rol>
    {
        Task<List<RolDTO>> buscarRolAsync();
    }
}
