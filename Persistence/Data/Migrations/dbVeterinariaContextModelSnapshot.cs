﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(dbVeterinariaContext))]
    partial class dbVeterinariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Persistence.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Fecha")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMascotaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdServicioFk")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "IdClienteFk");

                    b.HasIndex(new[] { "IdMascotaFk" }, "IdMascotaFk");

                    b.HasIndex(new[] { "IdServicioFk" }, "IdServicioFk");

                    b.ToTable("appointment", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreRaza")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("breed", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreCiudad")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdDepartamentoFk" }, "IdDepartamentoFk");

                    b.ToTable("city", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("client", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Clientaddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cardinal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LetraSec")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LetraTer")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoVia")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCiudadFk" }, "IdCiudadFk");

                    b.HasIndex(new[] { "IdClienteFk" }, "IdClienteFk")
                        .HasDatabaseName("IdClienteFk1");

                    b.ToTable("clientaddress", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Clientphone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "IdClienteFk")
                        .HasDatabaseName("IdClienteFk2");

                    b.ToTable("clientphone", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRazaFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "IdClienteFk")
                        .HasDatabaseName("IdClienteFk3");

                    b.HasIndex(new[] { "IdRazaFk" }, "IdRazaFk");

                    b.ToTable("pet", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Refreshtoken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime");

                    b.Property<int>("IdUserfK")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime");

                    b.Property<string>("Token")
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdUserfK" }, "IdUserfK");

                    b.ToTable("refreshtoken", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("double(11,2)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("service", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepartamento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPaisFk" }, "IdDepartamentoFk")
                        .HasDatabaseName("IdDepartamentoFk1");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Userrol", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdRol")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "IdRol" }, "IdRol");

                    b.ToTable("userrol", (string)null);
                });

            modelBuilder.Entity("Persistence.Entities.Appointment", b =>
                {
                    b.HasOne("Persistence.Entities.Client", "IdClienteFkNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdClienteFk")
                        .IsRequired()
                        .HasConstraintName("appointment_ibfk_1");

                    b.HasOne("Persistence.Entities.Pet", "IdMascotaFkNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdMascotaFk")
                        .IsRequired()
                        .HasConstraintName("appointment_ibfk_2");

                    b.HasOne("Persistence.Entities.Service", "IdServicioFkNavigation")
                        .WithMany("Appointments")
                        .HasForeignKey("IdServicioFk")
                        .IsRequired()
                        .HasConstraintName("appointment_ibfk_3");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdMascotaFkNavigation");

                    b.Navigation("IdServicioFkNavigation");
                });

            modelBuilder.Entity("Persistence.Entities.City", b =>
                {
                    b.HasOne("Persistence.Entities.State", "IdDepartamentoFkNavigation")
                        .WithMany("Cities")
                        .HasForeignKey("IdDepartamentoFk")
                        .IsRequired()
                        .HasConstraintName("city_ibfk_1");

                    b.Navigation("IdDepartamentoFkNavigation");
                });

            modelBuilder.Entity("Persistence.Entities.Clientaddress", b =>
                {
                    b.HasOne("Persistence.Entities.City", "IdCiudadFkNavigation")
                        .WithMany("Clientaddresses")
                        .HasForeignKey("IdCiudadFk")
                        .IsRequired()
                        .HasConstraintName("clientaddress_ibfk_2");

                    b.HasOne("Persistence.Entities.Client", "IdClienteFkNavigation")
                        .WithMany("Clientaddresses")
                        .HasForeignKey("IdClienteFk")
                        .IsRequired()
                        .HasConstraintName("clientaddress_ibfk_1");

                    b.Navigation("IdCiudadFkNavigation");

                    b.Navigation("IdClienteFkNavigation");
                });

            modelBuilder.Entity("Persistence.Entities.Clientphone", b =>
                {
                    b.HasOne("Persistence.Entities.Client", "IdClienteFkNavigation")
                        .WithMany("Clientphones")
                        .HasForeignKey("IdClienteFk")
                        .IsRequired()
                        .HasConstraintName("clientphone_ibfk_1");

                    b.Navigation("IdClienteFkNavigation");
                });

            modelBuilder.Entity("Persistence.Entities.Pet", b =>
                {
                    b.HasOne("Persistence.Entities.Client", "IdClienteFkNavigation")
                        .WithMany("Pets")
                        .HasForeignKey("IdClienteFk")
                        .IsRequired()
                        .HasConstraintName("pet_ibfk_2");

                    b.HasOne("Persistence.Entities.Breed", "IdRazaFkNavigation")
                        .WithMany("Pets")
                        .HasForeignKey("IdRazaFk")
                        .IsRequired()
                        .HasConstraintName("pet_ibfk_1");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdRazaFkNavigation");
                });

            modelBuilder.Entity("Persistence.Entities.Refreshtoken", b =>
                {
                    b.HasOne("Persistence.Entities.User", "IdUserfKNavigation")
                        .WithMany("Refreshtokens")
                        .HasForeignKey("IdUserfK")
                        .IsRequired()
                        .HasConstraintName("refreshtoken_ibfk_1");

                    b.Navigation("IdUserfKNavigation");
                });

            modelBuilder.Entity("Persistence.Entities.State", b =>
                {
                    b.HasOne("Persistence.Entities.Country", "IdPaisFkNavigation")
                        .WithMany("States")
                        .HasForeignKey("IdPaisFk")
                        .IsRequired()
                        .HasConstraintName("state_ibfk_1");

                    b.Navigation("IdPaisFkNavigation");
                });

            modelBuilder.Entity("Userrol", b =>
                {
                    b.HasOne("Persistence.Entities.Rol", null)
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .IsRequired()
                        .HasConstraintName("userrol_ibfk_2");

                    b.HasOne("Persistence.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .IsRequired()
                        .HasConstraintName("userrol_ibfk_1");
                });

            modelBuilder.Entity("Persistence.Entities.Breed", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Persistence.Entities.City", b =>
                {
                    b.Navigation("Clientaddresses");
                });

            modelBuilder.Entity("Persistence.Entities.Client", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Clientaddresses");

                    b.Navigation("Clientphones");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("Persistence.Entities.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("Persistence.Entities.Pet", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Persistence.Entities.Service", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Persistence.Entities.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Persistence.Entities.User", b =>
                {
                    b.Navigation("Refreshtokens");
                });
#pragma warning restore 612, 618
        }
    }
}
