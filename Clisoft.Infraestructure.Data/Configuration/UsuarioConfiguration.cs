using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.HasKey(e => e.IdUsuario);

            entity.Property(e => e.IdUsuario)
                .HasColumnName("idUsuario")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Contraseña)
                .IsRequired()
                .HasColumnName("contraseña")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.NombreUsuario)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
