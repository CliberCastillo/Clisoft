using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoAppService _empleadoAppService;
        public EmpleadoController(IEmpleadoAppService empleadoAppService)
        {
            _empleadoAppService = empleadoAppService;
        }
        [HttpGet]
        public ActionResult<List<EmpleadoDTO>> GetAll()
        {
            try
            {
                return _empleadoAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpleadoDTO>> GetByIdAsync(string id)
        {
            try
            {
                var empleadoPorId = await _empleadoAppService.GetByIdAsync(id);
                if (empleadoPorId == null)
                {
                    return NotFound();
                }
                return empleadoPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<EmpleadoDTO> Add([FromBody] EmpleadoDTO empleado)
        {
            try
            {
                empleado.IdEmpleado = _empleadoAppService.GenerarCodigo();
                _empleadoAppService.Add(empleado);
                _empleadoAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = empleado.IdEmpleado }, empleado);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<EmpleadoDTO> Update(string id, [FromBody] EmpleadoDTO empleado)
        {
            try
            {
                if (empleado == null)
                    return NotFound();
                _empleadoAppService.Update(empleado);
                _empleadoAppService.Save();
                return empleado;
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
                _empleadoAppService.Delete(id);
                _empleadoAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
