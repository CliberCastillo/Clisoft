using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Linq;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly ClisoftContext _context;

        public ClienteRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosCliente = _context.Cliente.Count();
            return "CL0" + (numeroRegistrosCliente + 1);
        }
    }
}
