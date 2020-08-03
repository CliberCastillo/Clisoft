using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Helper;
using Clisoft.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Service.Entity
{
    public class ClienteAppService : BaseAppService<ClienteDTO, Cliente>, IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteAppService(IClienteRepository clienteRepository, IMapper mapper) : base(clienteRepository, mapper)
        {
            _clienteRepository = clienteRepository;
        }

        public string GenerarCodigo()
        {
            return _clienteRepository.GenerarCodigo();
        }

        public async Task<ClienteUsuarioDTO> NombreCorreoClienteAsync(string usuario, string contraseña)
        {
            return _mapper.Map<ClienteUsuario,ClienteUsuarioDTO>(await _clienteRepository.NombreCorreoClienteAsync(usuario, contraseña));
        }
    }
}
