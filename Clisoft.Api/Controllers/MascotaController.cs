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
        public ActionResult<InsertarMascotaDTO> Add([FromBody] InsertarMascotaDTO insertarMascota)
        {
            try
            {
                _mascotaAppService.Add(insertarMascota);
                _mascotaAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = insertarMascota.IdCliente }, insertarMascota);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<InsertarMascotaDTO> Update(string id, [FromBody] InsertarMascotaDTO insertarMascota)
        {
            try
            {
                if (insertarMascota == null)
                    return NotFound();
                _mascotaAppService.Update(insertarMascota);
                _mascotaAppService.Save();
                return insertarMascota;
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
