namespace Clisoft.Domain.Entities
{
    public partial class PerfilExamen
    {
        public string IdPerfilExamen { get; set; }
        public string IdPerfil { get; set; }
        public string IdExamen { get; set; }
        public string NombreExamen { get; set; }

        public virtual Examen IdExamenNavigation { get; set; }
        public virtual Perfil IdPerfilNavigation { get; set; }
    }
}
