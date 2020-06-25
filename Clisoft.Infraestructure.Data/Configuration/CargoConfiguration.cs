using Clisoft.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clisoft.Infraestructure.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> entity)
        {
            entity.HasKey(e => e.IdCargo);

            entity.Property(e => e.IdCargo)
                .HasColumnName("idCargo")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
