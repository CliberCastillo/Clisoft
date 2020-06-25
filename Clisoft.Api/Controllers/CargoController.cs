using Clisoft.Aplication;
using Clisoft.Aplication.Interface.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly ICargoAppService _rolAppService;
        public CargoController(ICargoAppService rolAppService)
        {
            _rolAppService = rolAppService;
        }
        [HttpGet]
        public Task<List<CargoDTO>> ListadoDeCargos()
        {
             return  _rolAppService.buscarCargoAsync();
        }
    }
}
