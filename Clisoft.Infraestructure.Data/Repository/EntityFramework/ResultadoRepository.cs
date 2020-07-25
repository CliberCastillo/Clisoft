using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class ResultadoRepository : GenericRepository<Resultado>, IResultadoRepository
    {
        private readonly ClisoftContext _context;

        public ResultadoRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosResultado = _context.Resultado.Count();
            return "RE0" + (numeroRegistrosResultado + 1);
        }
    }
}
