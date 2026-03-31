using System;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public string Supplier { get; set; }
    public int Stock { get; set; }

    public bool IsFeatured { get; set; }
}
