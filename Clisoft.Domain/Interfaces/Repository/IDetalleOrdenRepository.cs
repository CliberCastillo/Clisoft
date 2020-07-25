using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IDetalleOrdenRepository : IGenericRepository<DetalleOrden>
    {
        string GenerarCodigo();
    }
}
