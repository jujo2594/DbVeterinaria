using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("city");

            builder.HasIndex(e => e.IdDepartamentoFk, "IdDepartamentoFk");

            builder.Property(e => e.NombreCiudad).HasMaxLength(50);

            builder.HasOne(d => d.IdDepartamentoFkNavigation).WithMany(p => p.Cities)
                .HasForeignKey(d => d.IdDepartamentoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("city_ibfk_1");
        }
    }
}