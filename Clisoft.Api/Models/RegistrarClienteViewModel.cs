using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Api.Models
{
    public class RegistrarClienteViewModel
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NombreContacto { get; set; }
        public string Distrito { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
    }
}
