using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilExamenController : ControllerBase
    {
        private readonly IPerfilExamenAppService _perfilExamenAppService;
        public PerfilExamenController(IPerfilExamenAppService perfilExamenAppService)
        {
            _perfilExamenAppService = perfilExamenAppService;
        }
        [HttpGet]
        public ActionResult<List<PerfilExamenDTO>> GetAll()
        {
            try
            {
                return _perfilExamenAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilExamenDTO>> GetByIdAsync(string id)
        {
            try
            {
                var perfilExamenPorId = await _perfilExamenAppService.GetByIdAsync(id);
                if (perfilExamenPorId == null)
                {
                    return NotFound();
                }
                return perfilExamenPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<PerfilExamenDTO> Add([FromBody] PerfilExamenDTO perfilExamen)
        {
            try
            {
                perfilExamen.IdPerfilExamen = _perfilExamenAppService.GenerarCodigo();
                _perfilExamenAppService.Add(perfilExamen);
                _perfilExamenAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = perfilExamen.IdPerfilExamen }, perfilExamen);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<PerfilExamenDTO> Update(string id, [FromBody] PerfilExamenDTO perfilExamen)
        {
            try
            {
                if (perfilExamen == null)
                    return NotFound();
                _perfilExamenAppService.Update(perfilExamen);
                _perfilExamenAppService.Save();
                return perfilExamen;
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
                _perfilExamenAppService.Delete(id);
                _perfilExamenAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
