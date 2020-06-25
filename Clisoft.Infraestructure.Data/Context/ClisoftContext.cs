using System;
using Clisoft.Domain.Entities;
using Clisoft.Infraestructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clisoft.Infraestructure.Data.Context
{
    public partial class ClisoftContext : DbContext
    {
        public ClisoftContext() { }

        public ClisoftContext(DbContextOptions<ClisoftContext> options) : base(options) { }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleOrden> DetalleOrden { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Examen> Examen { get; set; }
        public virtual DbSet<Mascota> Mascota { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilExamen> PerfilExamen { get; set; }
        public virtual DbSet<Resultado> Resultado { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CargoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new DetalleOrdenConfiguration());
            modelBuilder.ApplyConfiguration(new EmpleadoConfiguration());
            modelBuilder.ApplyConfiguration(new ExamenConfiguration());
            modelBuilder.ApplyConfiguration(new OrdenConfiguration());
            modelBuilder.ApplyConfiguration(new MascotaConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilExamenConfiguration());
            modelBuilder.ApplyConfiguration(new ResultadoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
