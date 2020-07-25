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
    public class ResultadoController : ControllerBase
    {
        private readonly IResultadoAppService _resultadoAppService;
        public ResultadoController(IResultadoAppService resultadoAppService)
        {
            _resultadoAppService = resultadoAppService;
        }
        [HttpGet]
        public ActionResult<List<ResultadoDTO>> GetAll()
        {
            try
            {
                return _resultadoAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ResultadoDTO>> GetByIdAsync(string id)
        {
            try
            {
                var resultadoPorId = await _resultadoAppService.GetByIdAsync(id);
                if (resultadoPorId == null)
                {
                    return NotFound();
                }
                return resultadoPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<ResultadoDTO> Add([FromBody] ResultadoDTO resultado)
        {
            try
            {
                resultado.IdResultado = _resultadoAppService.GenerarCodigo();
                _resultadoAppService.Add(resultado);
                _resultadoAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = resultado.IdResultado }, resultado);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<ResultadoDTO> Update(string id, [FromBody] ResultadoDTO resultado)
        {
            try
            {
                if (resultado == null)
                    return NotFound();
                _resultadoAppService.Update(resultado);
                _resultadoAppService.Save();
                return resultado;
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
                _resultadoAppService.Delete(id);
                _resultadoAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
