using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class DetalleOrden
    {
        public DetalleOrden()
        {
            Resultado = new HashSet<Resultado>();
        }

        public string IdDetalleOrden { get; set; }
        public string IdPerfil { get; set; }
        public string IdOrden { get; set; }
        public decimal CostoServicio { get; set; }

        public virtual Orden IdOrdenNavigation { get; set; }
        public virtual Perfil IdPerfilNavigation { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
    }
}
