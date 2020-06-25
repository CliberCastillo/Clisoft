using System;
using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class Orden
    {
        public Orden()
        {
            DetalleOrden = new HashSet<DetalleOrden>();
        }

        public string IdOrden { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Resultado { get; set; }
        public string IdCliente { get; set; }
        public string IdEmpleado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<DetalleOrden> DetalleOrden { get; set; }
    }
}
