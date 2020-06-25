using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> entity)
        {
            entity.HasKey(e => e.IdOrden);

            entity.Property(e => e.IdOrden)
                .HasColumnName("idOrden")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FechaRegistro)
                .HasColumnName("fechaRegistro")
                .HasColumnType("datetime");

            entity.Property(e => e.IdCliente)
                .IsRequired()
                .HasColumnName("idCliente")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdEmpleado)
                .IsRequired()
                .HasColumnName("idEmpleado")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Resultado)
                .IsRequired()
                .HasColumnName("resultado")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.Orden)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKOrdenCliente");

            entity.HasOne(d => d.IdEmpleadoNavigation)
                .WithMany(p => p.Orden)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKOrdenEmpleado");
        }
    }
}
