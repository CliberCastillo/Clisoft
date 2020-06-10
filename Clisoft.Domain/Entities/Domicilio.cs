namespace Clisoft.Domain.Entities
{
    public partial class Domicilio
    {
        public string IdDomicilio { get; set; }
        public int? IdUsuario { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string Referencia { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
