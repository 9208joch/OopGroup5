using System;

public class Order
{
    public int Id { get; set; }
    public List<OrderRow> Rows { get; set; } = new();
    public decimal TotalPrice { get; set; }

    public Customer Customer { get; set; }
}