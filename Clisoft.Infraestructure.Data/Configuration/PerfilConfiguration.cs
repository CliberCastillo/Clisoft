using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class PerfilConfiguration : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> entity)
        {
            entity.HasKey(e => e.IdPerfil);

            entity.Property(e => e.IdPerfil)
                .HasColumnName("idPerfil")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Costo)
                .HasColumnName("costo")
                .HasColumnType("decimal(18, 0)");

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
