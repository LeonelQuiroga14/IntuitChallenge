using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intuit.Challenge.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Actualizo_FechaNac_cliente_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Clientes",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Clientes",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2022, 9, 26, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2023, 7, 23, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2019, 12, 31, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2023, 8, 22, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2017, 4, 5, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5011));
        }
    }
}
