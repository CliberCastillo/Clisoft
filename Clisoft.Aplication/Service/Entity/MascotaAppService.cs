using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System.Collections.Generic;

namespace Clisoft.Aplication.Service.Entity
{
    public class MascotaAppService : BaseAppService<MascotaDTO,Mascota>, IMascotaAppService
    {
        private readonly IMascotaRepository _mascotaRepository;
        public MascotaAppService(IMascotaRepository mascotaRepository, IMapper mapper) : base(mascotaRepository, mapper)
        {
            _mascotaRepository = mascotaRepository;
        }
    }
}
