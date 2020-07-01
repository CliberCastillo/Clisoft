using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

namespace Clisoft.Aplication.Service.Entity
{
    public class PerfilAppService : BaseAppService<PerfilDTO,Perfil>,IPerfilAppService
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilAppService(IPerfilRepository perfilRepository, IMapper mapper) : base(perfilRepository, mapper)
        {
            _perfilRepository = perfilRepository;
        }
    }
}
