namespace Clisoft.Domain.Entities
{
    public partial class Resultado
    {
        public string IdResultado { get; set; }
        public string IdExamen { get; set; }
        public string IdDetalleOrden { get; set; }
        public string Resultado1 { get; set; }

        public virtual DetalleOrden IdDetalleOrdenNavigation { get; set; }
        public virtual Examen IdExamenNavigation { get; set; }
    }
}
