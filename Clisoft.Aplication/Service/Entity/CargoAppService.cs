using AutoMapper;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Service.Entity
{
    public class CargoAppService : BaseAppService<CargoDTO, Cargo>, ICargoAppService
    {
        private readonly ICargoRepository _cargoRepository;
        public CargoAppService(ICargoRepository rolRepository, IMapper mapper) : base(rolRepository, mapper)
        {
            _cargoRepository = rolRepository;
        }
        public async Task<List<CargoDTO>> buscarCargoAsync()
        {
            return _mapper.Map<List<Cargo>,List<CargoDTO>>(await _cargoRepository.buscarCargoAsync());
        }
    }
}
