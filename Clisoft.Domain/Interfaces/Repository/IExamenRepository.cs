﻿using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IExamenRepository : IGenericRepository<Examen>
    {
        string GenerarCodigo();
    }
}
