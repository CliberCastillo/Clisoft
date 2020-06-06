using System;
using System.Collections.Generic;

namespace Clisoft.Infraestructure.Data.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public string IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
