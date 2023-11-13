using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "breed",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NombreRaza = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "client",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Apellidos = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "country",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NombrePais = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "rol",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Nombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "service",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Precio = table.Column<double>(type: "double(11,2)", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "user",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Password = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "clientphone",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Numero = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdClienteFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "clientphone_ibfk_1",
            //             column: x => x.IdClienteFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "pet",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Especie = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
            //         IdRazaFk = table.Column<int>(type: "int", nullable: false),
            //         IdClienteFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "pet_ibfk_1",
            //             column: x => x.IdRazaFk,
            //             principalTable: "breed",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "pet_ibfk_2",
            //             column: x => x.IdClienteFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "state",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NombreDepartamento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdPaisFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "state_ibfk_1",
            //             column: x => x.IdPaisFk,
            //             principalTable: "country",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "refreshtoken",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Token = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Expires = table.Column<DateTime>(type: "datetime", nullable: false),
            //         Created = table.Column<DateTime>(type: "datetime", nullable: false),
            //         Revoked = table.Column<DateTime>(type: "datetime", nullable: true),
            //         IdUserfK = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "refreshtoken_ibfk_1",
            //             column: x => x.IdUserfK,
            //             principalTable: "user",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "userrol",
            //     columns: table => new
            //     {
            //         IdUser = table.Column<int>(type: "int", nullable: false),
            //         IdRol = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => new { x.IdUser, x.IdRol })
            //             .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            //         table.ForeignKey(
            //             name: "userrol_ibfk_1",
            //             column: x => x.IdUser,
            //             principalTable: "user",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "userrol_ibfk_2",
            //             column: x => x.IdRol,
            //             principalTable: "rol",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "appointment",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Fecha = table.Column<DateOnly>(type: "date", nullable: false),
            //         Hora = table.Column<TimeOnly>(type: "time", nullable: false),
            //         IdClienteFk = table.Column<int>(type: "int", nullable: false),
            //         IdMascotaFk = table.Column<int>(type: "int", nullable: false),
            //         IdServicioFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "appointment_ibfk_1",
            //             column: x => x.IdClienteFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "appointment_ibfk_2",
            //             column: x => x.IdMascotaFk,
            //             principalTable: "pet",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "appointment_ibfk_3",
            //             column: x => x.IdServicioFk,
            //             principalTable: "service",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "city",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         NombreCiudad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdDepartamentoFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "city_ibfk_1",
            //             column: x => x.IdDepartamentoFk,
            //             principalTable: "state",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "clientaddress",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         TipoVia = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         NumeroPri = table.Column<int>(type: "int", nullable: false),
            //         Letra = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Bis = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         LetraSec = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Cardinal = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         NumeroSec = table.Column<int>(type: "int", nullable: false),
            //         LetraTer = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         NumeroTer = table.Column<int>(type: "int", nullable: false),
            //         CardinalSec = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         CodigoPostal = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         IdClienteFk = table.Column<int>(type: "int", nullable: false),
            //         IdCiudadFk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.Id);
            //         table.ForeignKey(
            //             name: "clientaddress_ibfk_1",
            //             column: x => x.IdClienteFk,
            //             principalTable: "client",
            //             principalColumn: "Id");
            //         table.ForeignKey(
            //             name: "clientaddress_ibfk_2",
            //             column: x => x.IdCiudadFk,
            //             principalTable: "city",
            //             principalColumn: "Id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "IdClienteFk",
            //     table: "appointment",
            //     column: "IdClienteFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdMascotaFk",
            //     table: "appointment",
            //     column: "IdMascotaFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdServicioFk",
            //     table: "appointment",
            //     column: "IdServicioFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdDepartamentoFk",
            //     table: "city",
            //     column: "IdDepartamentoFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdCiudadFk",
            //     table: "clientaddress",
            //     column: "IdCiudadFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdClienteFk1",
            //     table: "clientaddress",
            //     column: "IdClienteFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdClienteFk2",
            //     table: "clientphone",
            //     column: "IdClienteFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdClienteFk3",
            //     table: "pet",
            //     column: "IdClienteFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdRazaFk",
            //     table: "pet",
            //     column: "IdRazaFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdUserfK",
            //     table: "refreshtoken",
            //     column: "IdUserfK");

            // migrationBuilder.CreateIndex(
            //     name: "IdDepartamentoFk1",
            //     table: "state",
            //     column: "IdPaisFk");

            // migrationBuilder.CreateIndex(
            //     name: "IdRol",
            //     table: "userrol",
            //     column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "appointment");

            // migrationBuilder.DropTable(
            //     name: "clientaddress");

            // migrationBuilder.DropTable(
            //     name: "clientphone");

            // migrationBuilder.DropTable(
            //     name: "refreshtoken");

            // migrationBuilder.DropTable(
            //     name: "userrol");

            // migrationBuilder.DropTable(
            //     name: "pet");

            // migrationBuilder.DropTable(
            //     name: "service");

            // migrationBuilder.DropTable(
            //     name: "city");

            // migrationBuilder.DropTable(
            //     name: "user");

            // migrationBuilder.DropTable(
            //     name: "rol");

            // migrationBuilder.DropTable(
            //     name: "breed");

            // migrationBuilder.DropTable(
            //     name: "client");

            // migrationBuilder.DropTable(
            //     name: "state");

            // migrationBuilder.DropTable(
            //     name: "country");
        }
    }
}
