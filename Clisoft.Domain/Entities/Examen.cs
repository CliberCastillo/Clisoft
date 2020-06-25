using System.Collections.Generic;

namespace Clisoft.Domain.Entities
{
    public partial class Examen
    {
        public Examen()
        {
            PerfilExamen = new HashSet<PerfilExamen>();
            Resultado = new HashSet<Resultado>();
        }

        public string IdExamen { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<PerfilExamen> PerfilExamen { get; set; }
        public virtual ICollection<Resultado> Resultado { get; set; }
    }
}
