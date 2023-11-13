using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class ClientPhoneConfiguration : IEntityTypeConfiguration<Clientphone>
    {
        public void Configure(EntityTypeBuilder<Clientphone> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("clientphone");

            builder.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            builder.Property(e => e.Numero).HasMaxLength(50);

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Clientphones)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientphone_ibfk_1");
        }
    }
}