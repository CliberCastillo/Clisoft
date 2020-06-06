using System;
using System.Collections.Generic;

namespace Clisoft.Infraestructure.Data.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Compras = new HashSet<Compras>();
            Domicilio = new HashSet<Domicilio>();
        }

        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public string IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Compras> Compras { get; set; }
        public virtual ICollection<Domicilio> Domicilio { get; set; }
    }
}
