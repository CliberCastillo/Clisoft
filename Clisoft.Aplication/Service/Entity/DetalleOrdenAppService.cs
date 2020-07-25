using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

namespace Clisoft.Aplication.Service.Entity
{
    public class DetalleOrdenAppService : BaseAppService<DetalleOrdenDTO, DetalleOrden>, IDetalleOrdenAppService
    {
        private readonly IDetalleOrdenRepository _detalleOrdenRepository;
        public DetalleOrdenAppService(IDetalleOrdenRepository detalleOrdenRepository, IMapper mapper) : base(detalleOrdenRepository, mapper)
        {
            _detalleOrdenRepository = detalleOrdenRepository;
        }

        public string GenerarCodigo()
        {
            return _detalleOrdenRepository.GenerarCodigo();
        }
    }
}
