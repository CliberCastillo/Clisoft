using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.HasKey(e => e.IdCliente);

            entity.HasIndex(e => e.IdUsuario);

            entity.Property(e => e.IdCliente)
                .HasColumnName("idCliente")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Direccion)
                .IsRequired()
                .HasColumnName("direccion")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Distrito)
                .IsRequired()
                .HasColumnName("distrito")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasColumnName("estado")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IdUsuario)
                .IsRequired()
                .HasColumnName("idUsuario")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NombreContacto)
                .IsRequired()
                .HasColumnName("nombreContacto")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Telefono)
                .IsRequired()
                .HasColumnName("telefono")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Cliente)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKClienteUSuario");
        }
    }
}
