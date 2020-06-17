using AutoMapper;
using Clisoft.Aplication.Interface;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Service.Entity
{
    public class RolAppService : BaseAppService<RolDTO, Rol>, IRolAppService
    {
        private readonly IRolRepository _rolRepository;

        public RolAppService(IRolRepository rolRepository, IMapper mapper):base(rolRepository, mapper)
        {
            _rolRepository = rolRepository;
        }
        public async Task<List<RolDTO>> buscarRolAsync(string id)
        {
            var lstRolesPorId =  _mapper.Map<List<RolDTO>>(_rolRepository.buscarRolAsync(id));
            return lstRolesPorId;
        }
    }
}
