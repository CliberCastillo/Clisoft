using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class ResultadoConfiguration : IEntityTypeConfiguration<Resultado>
    {
        public void Configure(EntityTypeBuilder<Resultado> entity)
        {
            entity.HasKey(e => e.IdResultado);

            entity.HasIndex(e => e.IdDetalleOrden);

            entity.HasIndex(e => e.IdExamen);

            entity.Property(e => e.IdResultado)
                .HasColumnName("idResultado")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.IdDetalleOrden)
                .IsRequired()
                .HasColumnName("idDetalleOrden")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.IdExamen)
                .IsRequired()
                .HasColumnName("idExamen")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.NombreResultado)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdDetalleOrdenNavigation)
                .WithMany(p => p.Resultado)
                .HasForeignKey(d => d.IdDetalleOrden)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKResultadoDetalleOrden");

            entity.HasOne(d => d.IdExamenNavigation)
                .WithMany(p => p.Resultado)
                .HasForeignKey(d => d.IdExamen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKResultadoExamen");
        }
    }
}
