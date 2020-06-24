using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> entity)
        {
            entity.HasKey(e => e.IdRol)
                  .HasName("PK__Rol__3C872F76800DAA62");

            entity.Property(e => e.IdRol)
                .HasColumnName("idRol")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        }
    }
}
