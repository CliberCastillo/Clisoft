using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class CargoRepository : IGenericRepository<Cargo>, ICargoRepository
    {

        private readonly ClisoftContext _context;

        public CargoRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Cargo>> buscarCargoAsync()
        {
            return await _context.Cargo.ToListAsync();
        }
    }
}
