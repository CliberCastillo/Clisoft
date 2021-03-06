﻿using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IEmpleadoAppService : IBaseAppService<EmpleadoDTO, Empleado>
    {
        string GenerarCodigo();
    }
}
