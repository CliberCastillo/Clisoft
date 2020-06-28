using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

namespace Clisoft.Aplication.Service.Entity
{
    public class UsuarioAppService : BaseAppService<UsuarioDTO, Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioAppService(IUsuarioRepository usuarioRepository, IMapper mapper) : base(usuarioRepository, mapper)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
