using Clisoft.Api.Models;
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
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAppService _usuarioAppService;
        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }
        [HttpGet]
        public ActionResult<List<UsuarioDTO>> GetAll()
        {
            try
            {
                return _usuarioAppService.GetAll();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDTO>> GetByIdAsync(string id)
        {
            try
            {
                var usuarioPorId = await _usuarioAppService.GetByIdAsync(id);
                if (usuarioPorId == null)
                {
                    return NotFound();
                }
                return usuarioPorId;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public ActionResult<UsuarioDTO> Add([FromBody] UsuarioDTO usuario)
        {
            try
            {
                usuario.IdUsuario = _usuarioAppService.GenerarCodigo();
                UsuarioDTO variable = usuario;
                _usuarioAppService.Add(variable);
                _usuarioAppService.Save();
                return CreatedAtAction(nameof(Add), new { id = usuario.NombreUsuario }, usuario);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public ActionResult<UsuarioDTO> Update(string id, [FromBody] UsuarioDTO usuario)
        {
            try
            {
                if (usuario == null)
                    return NotFound();
                _usuarioAppService.Update(usuario);
                _usuarioAppService.Save();
                return usuario;
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
                _usuarioAppService.Delete(id);
                _usuarioAppService.Save();
                return NoContent();

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("ValidarInicioSesion")]
        public async Task<ActionResult<bool>> ValidarInicioSesionAsync([FromBody] InicioSesion inicioSesion)
        {
            try
            {
                if (await _usuarioAppService.ValidarInicioSesionAsync(inicioSesion.nombreUsuario, inicioSesion.contraseña))
                    return true;
                return false;
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}