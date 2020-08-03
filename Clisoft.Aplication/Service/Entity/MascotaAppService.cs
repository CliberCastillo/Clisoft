using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Service.Entity
{
    public class MascotaAppService : BaseAppService<MascotaDTO,Mascota>, IMascotaAppService
    {
        private readonly IMascotaRepository _mascotaRepository;
        public MascotaAppService(IMascotaRepository mascotaRepository, IMapper mapper) : base(mascotaRepository, mapper)
        {
            _mascotaRepository = mascotaRepository;
        }

        public async Task<MascotaDTO> BuscarMascotaPorIdONombreAsync(string nombreid)
        {
            return _mapper.Map<Mascota, MascotaDTO>(await _mascotaRepository.BuscarMascotaPorIdONombreAsync(nombreid));
        }

        public string GenerarCodigo()
        {
            return _mascotaRepository.GenerarCodigo();
        }

        public async Task<List<MascotaDTO>> ListadoDeMascotasPorClienteAsync(string usuario, string contraseña)
        {
            
            return _mapper.Map<List<Mascota>, List<MascotaDTO>>(await _mascotaRepository.ListadoDeMascotasPorClienteAsync(usuario,contraseña));
        }
    }
}
