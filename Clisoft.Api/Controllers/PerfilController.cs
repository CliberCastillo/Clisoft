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
    public class PerfilController : ControllerBase
    {
        private readonly IPerfilAppService _perfilAppService;
        public PerfilController(IPerfilAppService perfilAppService)
        {
            _perfilAppService = perfilAppService;
        }
        [HttpGet]
        public ActionResult<List<PerfilDTO>> GetAll()
        {
            try
            {
                return _perfilAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PerfilDTO>> GetByIdAsync(string id)
        {
            try
            {
                var perfilPorId = await _perfilAppService.GetByIdAsync(id);
                if (perfilPorId == null)
                {
                    return NotFound();
                }
                return perfilPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<PerfilDTO> Add([FromBody] PerfilDTO perfil)
        {
            try
            {
                _perfilAppService.Add(perfil);
                _perfilAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = perfil.IdPerfil }, perfil);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<PerfilDTO> Update(string id, [FromBody] PerfilDTO perfil)
        {
            try
            {
                if (perfil == null)
                    return NotFound();
                _perfilAppService.Update(perfil);
                _perfilAppService.Save();
                return perfil;
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
                _perfilAppService.Delete(id);
                _perfilAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
