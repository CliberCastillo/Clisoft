using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

namespace Clisoft.Aplication.Service.Entity
{
    public class EmpleadoAppService : BaseAppService<EmpleadoDTO,Empleado>,IEmpleadoAppService
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        public EmpleadoAppService(IEmpleadoRepository empleadoRepository, IMapper mapper) : base(empleadoRepository    , mapper)
        {
            _empleadoRepository = empleadoRepository;
        }

        public string GenerarCodigo()
        {
            return _empleadoRepository.GenerarCodigo();
        }
    }
}
