using System;
using System.Collections.Generic;

namespace Clisoft.Infraestructure.Data.Entities
{
    public partial class Marca
    {
        public Marca()
        {
            Producto = new HashSet<Producto>();
        }

        public string IdMarca { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
