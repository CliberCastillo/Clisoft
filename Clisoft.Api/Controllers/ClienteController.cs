using Clisoft.Api.Models;
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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IUsuarioAppService _usuarioAppService;

        public ClienteController(IClienteAppService clienteAppService, IUsuarioAppService usuarioAppService)
        {
            _clienteAppService = clienteAppService;
            _usuarioAppService = usuarioAppService;
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
        public ActionResult<ClienteDTO> Add([FromBody] RegistrarClienteViewModel registrarCliente)
        {
            try
            {
                var generarIdUsuario = _usuarioAppService.GenerarCodigo();
                UsuarioDTO usuarioDTO = new UsuarioDTO
                {
                    IdUsuario = generarIdUsuario,
                    NombreUsuario = registrarCliente.nombreUsuario,
                    Contraseña = registrarCliente.contraseña
                };
                _usuarioAppService.Add(usuarioDTO);
                ClienteDTO cliente = new ClienteDTO
                {
                    Nombre = registrarCliente.Nombre,
                    Direccion = registrarCliente.Direccion,
                    Telefono = registrarCliente.Telefono,
                    NombreContacto = registrarCliente.NombreContacto,
                    Distrito = registrarCliente.Distrito,
                    Estado = "A",
                    IdUsuario = generarIdUsuario
                };
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
        [HttpPost("UsuarioCliente")]
        public async Task<ActionResult<ClienteUsuarioDTO>> NombreCorreoClienteAsync([FromBody] InicioSesionViewModel inicioSesion)
        {
            try
            {
                var clientePorInicioSesion = await _clienteAppService.NombreCorreoClienteAsync(inicioSesion.nombreUsuario, inicioSesion.contraseña);
                if (clientePorInicioSesion == null)
                {
                    return NotFound();
                }
                return clientePorInicioSesion;

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
