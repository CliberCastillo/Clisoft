﻿using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.Interface.Entity
{
    public interface IDetalleOrdenAppService : IBaseAppService<DetalleOrdenDTO,DetalleOrden>
    {
        string GenerarCodigo();
    }
}
