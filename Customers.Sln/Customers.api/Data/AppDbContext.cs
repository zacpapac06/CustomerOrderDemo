using Customers.api.Models;
using Microsoft.EntityFrameworkCore;

namespace Customers.api.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;


        // Configure the DbContext to use SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CustomerDB.db");  
        }

        // Fluent API to configure model relationships, keys
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Customers
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);  // Customer's primary key

                entity.Property(c => c.FirstName).IsRequired();  // FirstName is required
                entity.Property(c => c.LastName).IsRequired();  // LastName is required
                entity.Property(c => c.Address).IsRequired();  // Address is required
                entity.Property(c => c.PostalCode).IsRequired();  // PostalCode is required
            });

            //Orders
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(o => o.Id);  // Order's primary key
                entity.HasOne(o => o.Customer)  // Define the relationship: Order belongs to Customer
                      .WithMany(c => c.Orders)
                      .HasForeignKey(o => o.CustomerId);
            });

            //Items
            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(i => i.Id);  // Item's primary key
                entity.HasOne(i => i.Order)  // Define the relationship: Item belongs to Order
                      .WithMany(o => o.Items)
                      .HasForeignKey(i => i.OrderId);

                entity.HasOne(i => i.Product)  // Define the relationship: Item has a Product
                      .WithMany()
                      .HasForeignKey(i => i.ProductId);
            });

            //Products
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);  // Define the primary key for Product
                entity.Property(p => p.Name).IsRequired();  // Product Name is required
            });

            base.OnModelCreating(modelBuilder);
        }
}
}
