using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class RolRepository : EFRepository<Rol>, IRolRepository
    {

        private readonly BDMemoryKingsContext _context;

        public RolRepository(BDMemoryKingsContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Rol>> buscarRolAsync()
        {
            return await _context.Rol.ToListAsync();
        }
    }
}
