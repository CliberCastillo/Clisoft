using Clisoft.Domain.Entity;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class RolRepository : EFRepository<Rol>, IRolRepository
    {
        private readonly BDMemoryKingsContext _context;
        public RolRepository(BDMemoryKingsContext context) : base(context)
        {
            _context = context;
        }

        public List<Rol> role()
        {
            var nose = _context.Rol.ToList();
            return nose;
        }
    }
}
