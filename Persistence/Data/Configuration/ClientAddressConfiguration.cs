using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class ClientAddressConfiguration : IEntityTypeConfiguration<Clientaddress>
    {
        public void Configure(EntityTypeBuilder<Clientaddress> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("clientaddress");

            builder.HasIndex(e => e.IdCiudadFk, "IdCiudadFk");

            builder.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            builder.Property(e => e.Bis).HasMaxLength(10);
            builder.Property(e => e.Cardinal).HasMaxLength(10);
            builder.Property(e => e.CardinalSec).HasMaxLength(10);
            builder.Property(e => e.CodigoPostal).HasMaxLength(50);
            builder.Property(e => e.Complemento).HasMaxLength(50);
            builder.Property(e => e.Letra).HasMaxLength(10);
            builder.Property(e => e.LetraSec).HasMaxLength(10);
            builder.Property(e => e.LetraTer).HasMaxLength(10);
            builder.Property(e => e.TipoVia).HasMaxLength(10);

            builder.HasOne(d => d.IdCiudadFkNavigation).WithMany(p => p.Clientaddresses)
                .HasForeignKey(d => d.IdCiudadFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientaddress_ibfk_2");

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Clientaddresses)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientaddress_ibfk_1");
        }
    }
}