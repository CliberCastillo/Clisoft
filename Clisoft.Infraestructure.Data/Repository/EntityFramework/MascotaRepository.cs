using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class MascotaRepository : IGenericRepository<Mascota>, IMascotaRepository
    {
        private readonly ClisoftContext _context;

        public MascotaRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public List<Mascota> ListadoMascota()
        {
            var resultado = _context.Mascota.ToList();
            return resultado;
        }
    }
}
