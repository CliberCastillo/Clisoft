using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clisoft.Aplication;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRolAppService _rolAppService;
        public WeatherForecastController(IRolAppService rolAppService)
        {
            _rolAppService = rolAppService;
        }
        [HttpGet]
        public Task<List<Rol>> BuscarDatosPorid()
        {
             var nose =  _rolAppService.buscarRolAsync();
            return nose;
        }
    }
}
