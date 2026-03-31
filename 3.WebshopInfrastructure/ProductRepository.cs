using System;

public class ProductRepository : IProductRepository
{
    private readonly WebShopContext _context;

    public ProductRepository(WebShopContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
        => await _context.Products.ToListAsync();

    public async Task<Product> GetByIdAsync(int id)
        => await _context.Products.FindAsync(id);

    public async Task AddAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }
}