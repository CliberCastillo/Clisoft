﻿using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Linq;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrdenRepository
    {
        private readonly ClisoftContext _context;

        public DetalleOrdenRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosDetalleOrden = _context.DetalleOrden.Count();
            return "DO0" + (numeroRegistrosDetalleOrden + 1);
        }
    }
}
