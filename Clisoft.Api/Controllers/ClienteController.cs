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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;
        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }
        [HttpGet]
        public ActionResult<List<ClienteDTO>> GetAll()
        {
            try
            {
                return _clienteAppService.GetAll();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteDTO>> GetByIdAsync(string id)
        {
            try
            {
                var clientePorId = await _clienteAppService.GetByIdAsync(id);
                if (clientePorId == null)
                {
                    return NotFound();
                }
                return clientePorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<ClienteDTO> Add([FromBody] ClienteDTO cliente)
        {
            try
            {
                cliente.IdCliente = _clienteAppService.GenerarCodigo();
                _clienteAppService.Add(cliente);
                _clienteAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = cliente.IdCliente }, cliente);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<ClienteDTO> Update(string id, [FromBody] ClienteDTO cliente)
        {
            try
            {
                if (cliente == null)
                    return NotFound();
                _clienteAppService.Update(cliente);
                _clienteAppService.Save();
                return cliente;
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
                _clienteAppService.Delete(id);
                _clienteAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
