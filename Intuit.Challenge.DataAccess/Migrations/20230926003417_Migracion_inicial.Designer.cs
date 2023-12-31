﻿// <auto-generated />
using System;
using Intuit.Challenge.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Intuit.Challenge.DataAccess.Migrations
{
    [DbContext(typeof(IntuitAppDbContext))]
    [Migration("20230926003417_Migracion_inicial")]
    partial class Migracion_inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Intuit.Challenge.Core.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CUIT")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Domicilio")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("TelefonoCelular")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Ramirez",
                            CUIT = "20-55675555-7",
                            Domicilio = "Calle falsa 1232",
                            Email = "pedro.ramirez@email.com",
                            FechaNacimiento = new DateTime(2022, 9, 26, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(4997),
                            Nombre = "Pedro"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Abila",
                            Email = "ramon.abila@email.com",
                            FechaNacimiento = new DateTime(2023, 7, 23, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5008),
                            Nombre = "Ramon"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Díaz",
                            Email = "tomas.diaz@email.com",
                            FechaNacimiento = new DateTime(2019, 12, 31, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5009),
                            Nombre = "Tomas"
                        },
                        new
                        {
                            Id = 4,
                            Apellido = "Quiroga",
                            CUIT = "99-40235999-2",
                            Domicilio = "Calle falsa 123",
                            Email = "matias.quiroga@email.com",
                            FechaNacimiento = new DateTime(2023, 8, 22, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5010),
                            Nombre = "Matías"
                        },
                        new
                        {
                            Id = 5,
                            Apellido = "Messi",
                            CUIT = "23-41675897-5",
                            Domicilio = "Barcelona  3123",
                            Email = "lionel.messi@email.com",
                            FechaNacimiento = new DateTime(2017, 4, 5, 0, 34, 17, 40, DateTimeKind.Utc).AddTicks(5011),
                            Nombre = "Lionel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
