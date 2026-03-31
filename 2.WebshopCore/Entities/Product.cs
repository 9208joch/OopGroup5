using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Size { get; set; }

    [Range(0, 10000)]
    public decimal Price { get; set; }

    public decimal? SalePrice { get; set; }

    public bool IsOnSale { get; set; }

    public string Description { get; set; }

    public string Category { get; set; }

    [Range(0, int.MaxValue)] 
    public int Inventory { get; set; }
}