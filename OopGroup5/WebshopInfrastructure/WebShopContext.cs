using System;

public class WebShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public WebShopContext(DbContextOptions<WebShopContext> options)
        : base(options) { }
}
