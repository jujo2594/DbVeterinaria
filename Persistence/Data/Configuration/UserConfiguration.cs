using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("user");

            builder.Property(e => e.Email).HasMaxLength(100);
            builder.Property(e => e.Password).HasMaxLength(150);
            builder.Property(e => e.UserName).HasMaxLength(100);

            builder.HasMany(d => d.IdRols).WithMany(p => p.IdUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "Userrol",
                    r => r.HasOne<Rol>().WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("userrol_ibfk_2"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("userrol_ibfk_1"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdRol")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("userrol");
                        j.HasIndex(new[] { "IdRol" }, "IdRol");
                    });
        }
    }
}