using System;
using Microsoft.EntityFrameworkCore;

public class WebShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public WebShopContext(DbContextOptions<WebShopContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .HasCheckConstraint("CK_Product_Inventory", "[Inventory] >= 0");
    }
}