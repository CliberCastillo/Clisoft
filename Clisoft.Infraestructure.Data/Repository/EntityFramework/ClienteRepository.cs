using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class ClienteRepository : IGenericRepository<Cliente>, IClienteRepository
    {
        private readonly ClisoftContext _context;

        public ClienteRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }
    }
}
