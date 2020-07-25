using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

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
    }
}
