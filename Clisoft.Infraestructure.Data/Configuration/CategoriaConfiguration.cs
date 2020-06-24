using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> entity)
        {

            entity.HasKey(e => e.IdCategoria)
                .HasName("PK__Categori__8A3D240CF3333907");

            entity.Property(e => e.IdCategoria)
                .HasColumnName("idCategoria")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Foto)
                .HasColumnName("foto")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();

        }
    }
}
