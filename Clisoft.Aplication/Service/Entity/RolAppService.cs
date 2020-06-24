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
        //private readonly IEFRepository<Rol> _rolRepo;
        public RolAppService(IRolRepository rolRepository, /*IEFRepository<Rol> rolRepo,*/ IMapper mapper) : base(rolRepository, mapper)
        {
            _rolRepository = rolRepository;
            //_rolRepo = rolRepo;
        }
        public async Task<List<RolDTO>> buscarRolAsync()
        {
            return _mapper.Map<List<Rol>,List<RolDTO>>(await _rolRepository.buscarRolAsync());
        }
    }
}
