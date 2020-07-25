using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Linq;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class PerfilRepository : GenericRepository<Perfil>, IPerfilRepository
    {
        private readonly ClisoftContext _context;

        public PerfilRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosPerfil = _context.Perfil.Count();
            return "PE0" + (numeroRegistrosPerfil + 1);
        }
    }
}
