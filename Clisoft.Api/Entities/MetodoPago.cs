using System;
using System.Collections.Generic;

namespace Clisoft.Api.Entities
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Compras = new HashSet<Compras>();
        }

        public string IdPago { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Compras> Compras { get; set; }
    }
}
