﻿using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IExamenAppService : IBaseAppService<ExamenDTO, Examen>
    {
        string GenerarCodigo();
    }
}
