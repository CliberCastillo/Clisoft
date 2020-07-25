using Clisoft.Aplication;
using Clisoft.Aplication.Interface.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly ICargoAppService _cargoAppService;
        public CargoController(ICargoAppService cargoAppService)
        {
            _cargoAppService = cargoAppService;
        }
        [HttpGet]
        public ActionResult<List<CargoDTO>> GetAll()
        {
            try
            {
                return _cargoAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CargoDTO>> GetByIdAsync(string id)
        {
            try
            {
                var cargoPorId = await _cargoAppService.GetByIdAsync(id);
                if (cargoPorId == null)
                {
                    return NotFound();
                }
                return cargoPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<CargoDTO> Add([FromBody] CargoDTO cargo)
        {
            try
            {
                cargo.IdCargo = _cargoAppService.GenerarCodigo();
                _cargoAppService.Add(cargo);
                _cargoAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = cargo.IdCargo }, cargo);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<CargoDTO> Update(string id, [FromBody] CargoDTO cargo)
        {
            try
            {
                if (cargo == null)
                    return NotFound();
                _cargoAppService.Update(cargo);
                _cargoAppService.Save();
                return cargo;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                _cargoAppService.Delete(id);
                _cargoAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
