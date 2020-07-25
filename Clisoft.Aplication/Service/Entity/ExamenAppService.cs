using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

namespace Clisoft.Aplication.Service.Entity
{
    public class ExamenAppService : BaseAppService<ExamenDTO, Examen>, IExamenAppService
    {
        private readonly IExamenRepository _examenRepository;
        public ExamenAppService(IExamenRepository examenRepository, IMapper mapper) : base(examenRepository, mapper)
        {
            _examenRepository = examenRepository;
        }

        public string GenerarCodigo()
        {
            return _examenRepository.GenerarCodigo();

        }
    }
}
