using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class Empleado
    {
        public Empleado()
        {
            Orden = new HashSet<Orden>();
        }

        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public decimal Sueldo { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdCargo { get; set; }

        public virtual Cargo IdCargoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
