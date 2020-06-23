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
    public class RolAppService : /*BaseAppService<RolDTO, Rol>,*/ IRolAppService
    {
        private readonly IRolRepository _rolRepository;
        private readonly IMapper _mapper;

        public RolAppService(IRolRepository rolRepository, IMapper mapper)
        {
            _rolRepository = rolRepository;
            _mapper = mapper;

        }
        public async Task<List<Rol>> buscarRolAsync()
        {
            var listado = await _rolRepository.buscarRolAsync();
            return listado;
            //var lstRolesPorId =  _mapper.Map<List<RolDTO>>(_rolRepository.buscarRolAsync());
            //return lstRolesPorId;
        }
    }
}
