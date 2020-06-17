using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IRolAppService: IBaseAppService<RolDTO, Rol>
    {
        Task<List<RolDTO>> buscarRolAsync(string id);
    }
}
