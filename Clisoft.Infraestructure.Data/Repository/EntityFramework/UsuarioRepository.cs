using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        private readonly ClisoftContext _context;

        public UsuarioRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }

        public string GenerarCodigo()
        {
            var numeroUsuarios = _context.Usuario.Count();
            return "US0" + (numeroUsuarios + 1);
        }

        public async Task<bool> ValidarInicioSesionAsync(string usuario, string contraseña)
        {
            return await _context.Usuario.Where(x => x.NombreUsuario == usuario && x.Contraseña == contraseña).AnyAsync();
        }
    }
}
