using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
        }

        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
