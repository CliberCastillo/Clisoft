using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;

namespace Clisoft.Aplication.Service.Entity
{
    public class ResultadoAppService : BaseAppService<ResultadoDTO, Resultado>, IResultadoAppService
    {
        private readonly IResultadoRepository _resultadoRepository;
        public ResultadoAppService(IResultadoRepository resultadoRepository, IMapper mapper) : base(resultadoRepository, mapper)
        {
            _resultadoRepository = resultadoRepository;
        }

        public string GenerarCodigo()
        {
            return _resultadoRepository.GenerarCodigo();
        }
    }
}
