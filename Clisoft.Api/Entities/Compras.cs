using System;
using System.Collections.Generic;

namespace Clisoft.Api.Entities
{
    public partial class Compras
    {
        public Compras()
        {
            DetalleCompras = new HashSet<DetalleCompras>();
        }

        public int IdCompras { get; set; }
        public int? IdUsuario { get; set; }
        public string FechaCompras { get; set; }
        public decimal? Monto { get; set; }
        public string Estado { get; set; }
        public string IdPago { get; set; }

        public virtual MetodoPago IdPagoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleCompras> DetalleCompras { get; set; }
    }
}
