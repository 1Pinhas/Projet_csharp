using ProjetCsharp.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection.Emit;
namespace ProjetCsharp.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<RS> RS { get; set; }
    public DbSet<Comptable> Comptables { get; set; }
    public DbSet<Commande> Commandes { get; set; }
    public DbSet<Produit> Produits { get; set; }
    public DbSet<Livraison> Livraisons { get; set; }
    public DbSet<Livreur> Livreurs { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurez les relations ici, par exemple :
        modelBuilder.Entity<Client>()
            .HasMany(c => c.Commandes)
            .WithOne(c => c.Client)
            .HasForeignKey(c => c.ClientId);

        modelBuilder.Entity<Commande>()
            .HasMany(c => c.Produits)
            .WithMany(p => p.Commandes);

        modelBuilder.Entity<RS>()
            .HasMany(rs => rs.Commandes)
            .WithOne(c => c.RS)
            .HasForeignKey(c => c.RSId);
    }
}

