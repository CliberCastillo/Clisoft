using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class PerfilRepository : IGenericRepository<Perfil>, IPerfilRepository
    {
        private readonly ClisoftContext _context;

        public PerfilRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }
    }
}
