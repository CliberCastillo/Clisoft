using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Linq;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class OrdenRepository : GenericRepository<Orden>, IOrdenRepository
    {
        private readonly ClisoftContext _context;

        public OrdenRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosOrden = _context.Orden.Count();
            return "OR0" + (numeroRegistrosOrden + 1);
        }
    }
}
