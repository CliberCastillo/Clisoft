using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Collections.Generic;
using System.Linq;
namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class RolRepository : EFRepository<Rol>, IRolRepository
    {
        private readonly BDMemoryKingsContext _context;
        public RolRepository(BDMemoryKingsContext context) : base(context)
        {
            _context = context;
        }

        public List<Rol> role() => _context.Rol.ToList();
    }
}
