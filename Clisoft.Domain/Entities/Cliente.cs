using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Mascota = new HashSet<Mascota>();
            Orden = new HashSet<Orden>();
        }

        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NombreContacto { get; set; }
        public string Distrito { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Mascota> Mascota { get; set; }
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
