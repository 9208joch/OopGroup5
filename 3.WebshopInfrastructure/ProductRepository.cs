using System;

public class ProductRepository : IProductRepository
{
    private readonly WebShopContext _context;

    public ProductRepository(WebShopContext context)
    {
        _context = context;
    }
    //Funktionskontroll:
    public async Task<List<Product>> GetRandomProductsAsync(int count)
    {
        return await _context.Products
            .OrderBy(x => Guid.NewGuid()) // random
            .Take(count)
            .ToListAsync();
    }
    //Funktionskontroll:
    public async Task SeedProductsAsync()
    {
        if (_context.Products.Any())
            return;

        var products = ProductSeeder.GenerateProducts(1001);

        await _context.Products.AddRangeAsync(products);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Product>> GetAllAsync()
        => await _context.Products.ToListAsync();
}