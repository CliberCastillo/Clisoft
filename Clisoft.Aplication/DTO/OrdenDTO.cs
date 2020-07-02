using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.DTO
{
    public class OrdenDTO
    {
        public string IdOrden { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Resultado { get; set; }
        public string IdCliente { get; set; }
        public string IdEmpleado { get; set; }
    }
}
