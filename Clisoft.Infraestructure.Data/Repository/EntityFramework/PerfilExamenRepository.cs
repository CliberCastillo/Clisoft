﻿using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Linq;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class PerfilExamenRepository : GenericRepository<PerfilExamen>, IPerfilExamenRepository
    {
        private readonly ClisoftContext _context;

        public PerfilExamenRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosPerfilExamen = _context.PerfilExamen.Count();
            return "PX0" + (numeroRegistrosPerfilExamen + 1);
        }
    }
}
