using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> entity)
        {
            entity.HasKey(e => e.IdDetalleOrden);

            entity.Property(e => e.IdDetalleOrden)
                .HasColumnName("idDetalleOrden")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.CostoServicio)
                .HasColumnName("costoServicio")
                .HasColumnType("decimal(18, 0)");

            entity.Property(e => e.IdOrden)
                .IsRequired()
                .HasColumnName("idOrden")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdPerfil)
                .IsRequired()
                .HasColumnName("idPerfil")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.IdOrdenNavigation)
                .WithMany(p => p.DetalleOrden)
                .HasForeignKey(d => d.IdOrden)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKDetalleOrdenOrden");

            entity.HasOne(d => d.IdPerfilNavigation)
                .WithMany(p => p.DetalleOrden)
                .HasForeignKey(d => d.IdPerfil)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKDetalleOrdenPerfil");
        }
    }
}
