using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class ExamenConfiguration : IEntityTypeConfiguration<Examen>
    {
        public void Configure(EntityTypeBuilder<Examen> entity)
        {
            entity.HasKey(e => e.IdExamen);

            entity.Property(e => e.IdExamen)
                .HasColumnName("idExamen")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("nombre")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Tipo)
                .IsRequired()
                .HasColumnName("tipo")
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
