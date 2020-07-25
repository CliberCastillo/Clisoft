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
    public class ExamenController : ControllerBase
    {
        private readonly IExamenAppService _examenAppService;
        public ExamenController(IExamenAppService examenAppService)
        {
            _examenAppService = examenAppService;
        }
        [HttpGet]
        public ActionResult<List<ExamenDTO>> GetAll()
        {
            try
            {
                return _examenAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ExamenDTO>> GetByIdAsync(string id)
        {
            try
            {
                var examenPorId = await _examenAppService.GetByIdAsync(id);
                if (examenPorId == null)
                {
                    return NotFound();
                }
                return examenPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<ExamenDTO> Add([FromBody] ExamenDTO examen)
        {
            try
            {
                examen.IdExamen = _examenAppService.GenerarCodigo();
                _examenAppService.Add(examen);
                _examenAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = examen.IdExamen }, examen);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<ExamenDTO> Update(string id, [FromBody] ExamenDTO examen)
        {
            try
            {
                if (examen == null)
                    return NotFound();
                _examenAppService.Update(examen);
                _examenAppService.Save();
                return examen;
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
                _examenAppService.Delete(id);
                _examenAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
