using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("state");

            builder.HasIndex(e => e.IdPaisFk, "IdDepartamentoFk");

            builder.Property(e => e.NombreDepartamento).HasMaxLength(50);

            builder.HasOne(d => d.IdPaisFkNavigation).WithMany(p => p.States)
                .HasForeignKey(d => d.IdPaisFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("state_ibfk_1");
        }
    }
}