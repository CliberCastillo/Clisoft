using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class MascotaRepository : GenericRepository<Mascota>, IMascotaRepository
    {
        private readonly ClisoftContext _context;

        public MascotaRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosMascota = _context.Mascota.Count();
            return "MA0" + (numeroRegistrosMascota + 1);
        }

        public async Task<List<Mascota>> ListadoDeMascotasPorClienteAsync(string usuario, string contraseña)
        {
            var idUsuario = _context.Usuario.Where(x => x.NombreUsuario == usuario && x.Contraseña == contraseña)
                                            .Select(x => x.IdUsuario)
                                            .FirstOrDefault();

            var idCliente = _context.Cliente.Where(x => x.IdUsuario == idUsuario)
                                            .Select(x => x.IdCliente)
                                            .FirstOrDefault();

            return await _context.Mascota.Where(x => x.IdCliente == idCliente)
                                            .Select(x => new Mascota
                                            {
                                                IdMascota = x.IdMascota,
                                                Nombre = x.Nombre,
                                                Genero = x.Genero,
                                                Raza = x.Raza,
                                                Especie = x.Especie
                                            })                           
                                            .ToListAsync();
        }
    }
}
