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
                return _mascotaAppService.ListadoMascota();
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
    }
}
