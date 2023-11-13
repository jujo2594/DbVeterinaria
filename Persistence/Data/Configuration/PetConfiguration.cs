using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("pet");

            builder.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            builder.HasIndex(e => e.IdRazaFk, "IdRazaFk");

            builder.Property(e => e.Especie).HasMaxLength(50);
            builder.Property(e => e.Nombre).HasMaxLength(50);

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Pets)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pet_ibfk_2");

            builder.HasOne(d => d.IdRazaFkNavigation).WithMany(p => p.Pets)
                .HasForeignKey(d => d.IdRazaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pet_ibfk_1");
        }
    }
}