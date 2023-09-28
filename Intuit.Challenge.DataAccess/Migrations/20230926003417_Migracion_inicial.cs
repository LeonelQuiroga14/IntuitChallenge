using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Intuit.Challenge.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migracion_inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    CUIT = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Domicilio = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    TelefonoCelular = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Apellido", "CUIT", "Domicilio", "Email", "FechaNacimiento", "Nombre", "TelefonoCelular" },
                values: new object[,]
                {
                    { 1, "Ramirez", "20-55675555-7", "Calle falsa 1232", "pedro.ramirez@email.com", new DateTime(2022, 9, 26, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(4997), "Pedro", null },
                    { 2, "Abila", null, null, "ramon.abila@email.com", new DateTime(2023, 7, 23, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5008), "Ramon", null },
                    { 3, "Díaz", null, null, "tomas.diaz@email.com", new DateTime(2019, 12, 31, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5009), "Tomas", null },
                    { 4, "Quiroga", "99-40235999-2", "Calle falsa 123", "matias.quiroga@email.com", new DateTime(2023, 8, 22, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5010), "Matías", null },
                    { 5, "Messi", "23-41675897-5", "Barcelona  3123", "lionel.messi@email.com", new DateTime(2017, 4, 5, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5011), "Lionel", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
