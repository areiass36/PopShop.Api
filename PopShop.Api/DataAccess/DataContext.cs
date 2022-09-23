using Microsoft.EntityFrameworkCore;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess;

//DataContext é o nosso DAO
public class DataContext : DbContext
{
    public const string SCHEMA = "dbo";
    private readonly IConfiguration _configuration;
    public DataContext(IConfiguration configuration) => _configuration = configuration;

    //public virtual DbSet<Address> Addresses { get; set; }
    //public virtual DbSet<Cart> Carts { get; set; }
    //public virtual DbSet<Document> Documents { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    //public virtual DbSet<Sale> Sales { get; set; }
    //public virtual DbSet<Store> Stores { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            t => t?.Namespace?.EndsWith("Configurations") ?? false);
        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var connectionString = _configuration.GetConnectionString("Database");
        options.UseSqlServer(connectionString);
    }
}