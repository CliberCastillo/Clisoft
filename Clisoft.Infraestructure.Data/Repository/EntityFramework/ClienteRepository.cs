using Clisoft.Domain.Entities;
using Clisoft.Domain.Helper;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly ClisoftContext _context;

        public ClienteRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroRegistrosCliente = _context.Cliente.Count();
            return "CL0" + (numeroRegistrosCliente + 1);
        }

        public async Task<ClienteUsuario> NombreCorreoClienteAsync(string usuario, string contraseña)
        {
            return await _context.Cliente
                        .Join(_context.Usuario, c => c.IdUsuario, u => u.IdUsuario, (cliente, usuario) => new { cliente, usuario })
                        .Where(x => x.usuario.NombreUsuario == usuario && x.usuario.Contraseña == contraseña)
                        .Select(x => new ClienteUsuario
                        {
                            Nombre = x.cliente.Nombre,
                            Correo = x.usuario.NombreUsuario
                        })
                        .FirstOrDefaultAsync();
        }
    }
}
