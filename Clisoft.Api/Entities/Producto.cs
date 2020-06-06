using System;
using System.Collections.Generic;

namespace Clisoft.Api.Entities
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCompras = new HashSet<DetalleCompras>();
        }

        public string IdProducto { get; set; }
        public string Nombres { get; set; }
        public string IdCategoria { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string IdMarca { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Marca IdMarcaNavigation { get; set; }
        public virtual ICollection<DetalleCompras> DetalleCompras { get; set; }
    }
}
