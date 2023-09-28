using Intuit.Challenge.Core.Models;
using Intuit.Challenge.DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Intuit.Challenge.DataAccess.Contexts;

public class IntuitAppDbContext : DbContext
{
    public IntuitAppDbContext(DbContextOptions<IntuitAppDbContext> options):base(options)
    {
            
    }

    public DbSet<Cliente> Clientes { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new ClienteEntityConfiguration().Configure(modelBuilder.Entity<Cliente>());
    }
}

