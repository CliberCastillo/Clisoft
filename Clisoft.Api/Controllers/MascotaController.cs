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
    public class MascotaController : ControllerBase
    {
        private readonly IMascotaAppService _mascotaAppService;
        public MascotaController(IMascotaAppService mascotaAppService)
        {
            _mascotaAppService = mascotaAppService;
        }
        [HttpGet]
        public ActionResult<List<MascotaDTO>> GetAll()
        {
            try
            {
                return _mascotaAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<MascotaDTO>> GetByIdAsync(string id)
        {
            try
            {
                var mascotaPorId = await _mascotaAppService.GetByIdAsync(id);
                if (mascotaPorId == null)
                {
                    return NotFound();
                }
                return mascotaPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<MascotaDTO> Add([FromBody] MascotaDTO mascota)
        {
            try
            {
                mascota.IdMascota = _mascotaAppService.GenerarCodigo();
                _mascotaAppService.Add(mascota);
                _mascotaAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = mascota.IdMascota }, mascota);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<MascotaDTO> Update(string id, [FromBody] MascotaDTO mascota)
        {
            try
            {
                if (mascota == null)
                    return NotFound();
                _mascotaAppService.Update(mascota);
                _mascotaAppService.Save();
                return mascota;
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
                _mascotaAppService.Delete(id);
                _mascotaAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
