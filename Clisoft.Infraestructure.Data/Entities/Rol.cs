using System;
using System.Collections.Generic;

namespace Clisoft.Infraestructure.Data.Entities
{
    public partial class Rol
    {
        public Rol()
        {
            Usuario = new HashSet<Usuario>();
        }

        public string IdRol { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
