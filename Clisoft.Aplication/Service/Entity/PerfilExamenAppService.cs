using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.Service.Entity
{
    public class PerfilExamenAppService : BaseAppService<PerfilExamenDTO,PerfilExamen>, IPerfilExamenAppService
    {
        private readonly IPerfilExamenRepository _perfilExamenRepository;
        public PerfilExamenAppService(IPerfilExamenRepository perfilExamenRepository, IMapper mapper) : base(perfilExamenRepository, mapper)
        {
            _perfilExamenRepository = perfilExamenRepository;
        }
    }
}
