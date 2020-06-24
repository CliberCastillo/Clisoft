using Clisoft.Aplication;
using Clisoft.Aplication.Interface.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolController : ControllerBase
    {
        private readonly IRolAppService _rolAppService;
        public RolController(IRolAppService rolAppService)
        {
            _rolAppService = rolAppService;
        }
        [HttpGet]
        public Task<List<RolDTO>> BuscarDatosPorid()
        {
             return  _rolAppService.buscarRolAsync();
        }
    }
}
