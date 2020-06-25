using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class PerfilExamenConfiguration : IEntityTypeConfiguration<PerfilExamen>
    {
        public void Configure(EntityTypeBuilder<PerfilExamen> entity)
        {
            entity.HasKey(e => e.IdPerfilExamen);

            entity.Property(e => e.IdPerfilExamen)
                .HasColumnName("idPerfilExamen")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdExamen)
                .IsRequired()
                .HasColumnName("idExamen")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdPerfil)
                .IsRequired()
                .HasColumnName("idPerfil")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.NombreExamen)
                .IsRequired()
                .HasColumnName("nombreExamen")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdExamenNavigation)
                .WithMany(p => p.PerfilExamen)
                .HasForeignKey(d => d.IdExamen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPerfilExamenExamen");

            entity.HasOne(d => d.IdPerfilNavigation)
                .WithMany(p => p.PerfilExamen)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPerfilExamenPerfil");
        }
    }
}
