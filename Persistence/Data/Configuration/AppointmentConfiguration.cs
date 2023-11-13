using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Entities;

namespace Persistence.Data.Configuration
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("appointment");

            builder.HasIndex(e => e.IdClienteFk, "IdClienteFk");

            builder.HasIndex(e => e.IdMascotaFk, "IdMascotaFk");

            builder.HasIndex(e => e.IdServicioFk, "IdServicioFk");

            builder.Property(e => e.Hora).HasColumnType("time");

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("appointment_ibfk_1");

            builder.HasOne(d => d.IdMascotaFkNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdMascotaFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("appointment_ibfk_2");

            builder.HasOne(d => d.IdServicioFkNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.IdServicioFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("appointment_ibfk_3");
        }
    }
}