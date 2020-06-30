using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IMascotaAppService : IBaseAppService<MascotaDTO,Mascota>
    {
        List<MascotaDTO> ListadoMascota();
    }
}
