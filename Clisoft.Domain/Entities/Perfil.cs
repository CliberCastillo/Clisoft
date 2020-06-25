using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class Perfil
    {
        public Perfil()
        {
            DetalleOrden = new HashSet<DetalleOrden>();
            PerfilExamen = new HashSet<PerfilExamen>();
        }

        public string IdPerfil { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }

        public virtual ICollection<DetalleOrden> DetalleOrden { get; set; }
        public virtual ICollection<PerfilExamen> PerfilExamen { get; set; }
    }
}
