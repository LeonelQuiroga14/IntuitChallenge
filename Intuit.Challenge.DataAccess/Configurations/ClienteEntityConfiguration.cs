using Intuit.Challenge.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Intuit.Challenge.DataAccess.Configurations;

internal class ClienteEntityConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nombre).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(x => x.Apellido).HasColumnType("nvarchar(200)").IsRequired();
        builder.Property(x => x.CUIT).HasColumnType("nvarchar(15)").IsRequired(false);
        builder.Property(x => x.Domicilio).HasColumnType("nvarchar(1000)").IsRequired(false);
        builder.Property(x => x.TelefonoCelular).HasColumnType("nvarchar(50)").IsRequired(false);
        builder.Property(x => x.Email).HasColumnType("nvarchar(100)").IsRequired(false); 
        builder.Property(x => x.FechaNacimiento).HasColumnType("datetime").IsRequired(false);

        builder.HasIndex(x => new { x.Nombre, x.Apellido, x.CUIT }, "UX_Cliente_nombre_apellido_cuit").IsUnique(true);
        builder.HasIndex(x => x.Nombre, "IX_Cliente_nombre");
        builder.HasIndex(x => x.Apellido, "IX_Cliente_apellido");
        AddSeedData(builder);
    }

    private void AddSeedData(EntityTypeBuilder<Cliente> builder)
    {
        builder.HasData(new Cliente[]
        {
            new(1,nombre: "Pedro", apellido:"Ramirez", fechaNac: DateTime.UtcNow.AddDays(-365),"20-55675555-7",email:"pedro.ramirez@email.com",domicilio:"Calle falsa 1232"),
            new(2,nombre: "Ramon", apellido:"Abila", fechaNac: DateTime.UtcNow.AddDays(-65),email:"ramon.abila@email.com"),
            new(3,nombre: "Tomas", apellido:"Díaz", fechaNac: DateTime.UtcNow.AddDays(-1365),email:"tomas.diaz@email.com"),
            new(4,nombre: "Matías", apellido:"Quiroga", fechaNac: DateTime.UtcNow.AddDays(-35),"99-40235999-2",email:"matias.quiroga@email.com",domicilio:"Calle falsa 123"),
            new(5,nombre: "Lionel", apellido:"Messi", fechaNac: DateTime.UtcNow.AddDays(-2365),"23-41675897-5",email:"lionel.messi@email.com",domicilio:"Barcelona  3123"),


        });
    }
}

