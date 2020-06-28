using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class UsuarioRepository : IGenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly ClisoftContext _context;

        public UsuarioRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }
    }
}
