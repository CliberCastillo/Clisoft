namespace Clisoft.Domain.Entities
{
    public partial class Mascota
    {
        public string IdMascota { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
