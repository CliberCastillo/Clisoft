using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clisoft.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetalleOrdenController : ControllerBase
    {
        private readonly IDetalleOrdenAppService _detalleOrdenAppService;
        public DetalleOrdenController(IDetalleOrdenAppService detalleOrdenAppService)
        {
            _detalleOrdenAppService = detalleOrdenAppService;
        }
        [HttpGet]
        public ActionResult<List<DetalleOrdenDTO>> GetAll()
        {
            try
            {
                return _detalleOrdenAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleOrdenDTO>> GetByIdAsync(string id)
        {
            try
            {
                var detalleOrdenPorId = await _detalleOrdenAppService.GetByIdAsync(id);
                if (detalleOrdenPorId == null)
                {
                    return NotFound();
                }
                return detalleOrdenPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<DetalleOrdenDTO> Add([FromBody] DetalleOrdenDTO detalleOrden)
        {
            try
            {
                detalleOrden.IdDetalleOrden = _detalleOrdenAppService.GenerarCodigo();
                _detalleOrdenAppService.Add(detalleOrden);
                _detalleOrdenAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = detalleOrden.IdDetalleOrden }, detalleOrden);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<DetalleOrdenDTO> Update(string id, [FromBody] DetalleOrdenDTO detalleOrden)
        {
            try
            {
                if (detalleOrden == null)
                    return NotFound();
                _detalleOrdenAppService.Update(detalleOrden);
                _detalleOrdenAppService.Save();
                return detalleOrden;
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
                _detalleOrdenAppService.Delete(id);
                _detalleOrdenAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
