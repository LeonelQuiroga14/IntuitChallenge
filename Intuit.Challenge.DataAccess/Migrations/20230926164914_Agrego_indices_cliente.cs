using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intuit.Challenge.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Agrego_indices_cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2022, 9, 26, 16, 49, 14, 251, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2023, 7, 23, 16, 49, 14, 251, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2019, 12, 31, 16, 49, 14, 251, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2023, 8, 22, 16, 49, 14, 251, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2017, 4, 5, 16, 49, 14, 251, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_apellido",
                table: "Clientes",
                column: "Apellido");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_nombre",
                table: "Clientes",
                column: "Nombre");

            migrationBuilder.CreateIndex(
                name: "UX_Cliente_nombre_apellido_cuit",
                table: "Clientes",
                columns: new[] { "Nombre", "Apellido", "CUIT" },
                unique: true,
                filter: "[CUIT] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cliente_apellido",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_nombre",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "UX_Cliente_nombre_apellido_cuit",
                table: "Clientes");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2022, 9, 26, 16, 29, 22, 857, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2023, 7, 23, 16, 29, 22, 857, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2019, 12, 31, 16, 29, 22, 857, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2023, 8, 22, 16, 29, 22, 857, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2017, 4, 5, 16, 29, 22, 857, DateTimeKind.Utc).AddTicks(7452));
        }
    }
}
