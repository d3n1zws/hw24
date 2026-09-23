using System.Reflection.Metadata;

namespace ConsoleApp24.models;

public class OrderItem
{
    public OrderItem(int product, string productName, decimal price, int quantity)
    {
        Product = product;
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }

    public int Product { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public OrderItem DeepCopy() =>
        new OrderItem(Product, ProductName, Price, Quantity);

}
