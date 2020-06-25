using Clisoft.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface ICargoAppService : IBaseAppService<CargoDTO, Cargo>
    {
        Task<List<CargoDTO>> buscarCargoAsync();
    }
}
