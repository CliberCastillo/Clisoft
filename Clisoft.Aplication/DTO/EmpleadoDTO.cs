using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.DTO
{
    public class EmpleadoDTO
    {
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public decimal Sueldo { get; set; }
        public string Estado { get; set; }
    }
}
