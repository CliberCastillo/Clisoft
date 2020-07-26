using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> entity)
        {
            entity.HasKey(e => e.IdEmpleado);

            entity.HasIndex(e => e.IdCargo);

            entity.HasIndex(e => e.IdUsuario);

            entity.Property(e => e.IdEmpleado)
                .HasColumnName("idEmpleado")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Dni)
                .IsRequired()
                .HasColumnName("dni")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IdCargo)
                .IsRequired()
                .HasColumnName("idCargo")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.IdUsuario)
                .IsRequired()
                .HasColumnName("idUsuario")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Sueldo)
                .HasColumnName("sueldo")
                .HasColumnType("decimal(18, 0)");

            entity.Property(e => e.Telefono)
                .IsRequired()
                .HasColumnName("telefono")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCargoNavigation)
                .WithMany(p => p.Empleado)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKEmpleadoCargo");

            entity.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Empleado)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKEmpleadoUsuario");
        }
    }
}
