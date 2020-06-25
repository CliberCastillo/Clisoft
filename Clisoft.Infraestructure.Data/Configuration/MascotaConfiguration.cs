using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
    {
        public void Configure(EntityTypeBuilder<Mascota> entity)
        {
            entity.HasKey(e => e.IdMascota);

            entity.Property(e => e.IdMascota)
                .HasColumnName("idMascota")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdCliente)
                .IsRequired()
                .HasColumnName("idCliente")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Raza)
                .IsRequired()
                .HasColumnName("raza")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Mascota)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKMascotaCliente");
        }
    }
}
