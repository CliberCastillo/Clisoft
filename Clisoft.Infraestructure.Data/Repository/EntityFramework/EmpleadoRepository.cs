using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleadoRepository
    {
        private readonly ClisoftContext _context;

        public EmpleadoRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }
    }
}
