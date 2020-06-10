using System.Collections.Generic;

namespace Clisoft.Domain.Entities
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
