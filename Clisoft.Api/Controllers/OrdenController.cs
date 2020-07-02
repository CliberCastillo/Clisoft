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
    [Route("[controller]")]
    public class OrdenController : ControllerBase
    {
        private readonly IOrdenAppService _ordenAppService;
        public OrdenController(IOrdenAppService ordenAppService)
        {
            _ordenAppService = ordenAppService;
        }
        [HttpGet]
        public ActionResult<List<OrdenDTO>> GetAll()
        {
            try
            {
                return _ordenAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdenDTO>> GetByIdAsync(string id)
        {
            try
            {
                var ordenPorId = await _ordenAppService.GetByIdAsync(id);
                if (ordenPorId == null)
                {
                    return NotFound();
                }
                return ordenPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<OrdenDTO> Add([FromBody] OrdenDTO orden)
        {
            try
            {
                _ordenAppService.Add(orden);
                _ordenAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = orden.IdOrden }, orden);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<OrdenDTO> Update(string id, [FromBody] OrdenDTO orden)
        {
            try
            {
                if (orden == null)
                    return NotFound();
                _ordenAppService.Update(orden);
                _ordenAppService.Save();
                return orden;
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
                _ordenAppService.Delete(id);
                _ordenAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
