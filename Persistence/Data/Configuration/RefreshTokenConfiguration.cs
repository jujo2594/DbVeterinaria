using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<Refreshtoken>
    {
        public void Configure(EntityTypeBuilder<Refreshtoken> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("refreshtoken");

            builder.HasIndex(e => e.IdUserfK, "IdUserfK");

            builder.Property(e => e.Created).HasColumnType("datetime");
            builder.Property(e => e.Expires).HasColumnType("datetime");
            builder.Property(e => e.Revoked).HasColumnType("datetime");
            builder.Property(e => e.Token).HasMaxLength(250);

            builder.HasOne(d => d.IdUserfKNavigation).WithMany(p => p.Refreshtokens)
                .HasForeignKey(d => d.IdUserfK)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("refreshtoken_ibfk_1");
        }
    }
}