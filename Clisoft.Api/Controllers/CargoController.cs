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
        private readonly ICargoAppService _cargoAppService;
        public CargoController(ICargoAppService cargoAppService)
        {
            _cargoAppService = cargoAppService;
        }
        [HttpGet]
        public List<CargoDTO> GetAll()
        {
            return _cargoAppService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<CargoDTO> GetByIdAsync(string id)
        {
            return await _cargoAppService.GetByIdAsync(id);
        }
        [HttpPost]
        public ActionResult Add([FromBody] CargoDTO cargo)
        {
            _cargoAppService.Add(cargo);
            _cargoAppService.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Update(string id, [FromBody] CargoDTO cargo)
        {
            _cargoAppService.Update(cargo);
            _cargoAppService.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _cargoAppService.Delete(id);
            _cargoAppService.Save();
            return Ok();
        }
    }
}
