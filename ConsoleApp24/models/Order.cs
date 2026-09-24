namespace ConsoleApp24.models;

using ConsoleApp24.interfaces;
using ConsoleApp24.records;
using ConsoleApp24.enums;
public class Order: IEntity
{
    private static int _idCounter;
    public int Id { get; }
    public CustomerRecord Customer { get; init; }
    public List<OrderItem> Items { get; set; }
    public OrderStatus Status { get; set; }
    public readonly DateTime OrderDate;
    public decimal TotalAmount => Items.Sum(x => x.Price * x.Quantity);
    public OrderItem this[int index] => Items[index];
    //explict operator
    public static explicit operator decimal(Order order)
    {
        return order.TotalAmount;
    }
    public override string ToString()
    {
        return $"Status: {Status}, Customer: {Customer}, Order Date: {OrderDate}";
    }
    public static implicit operator string(Order order)
    {
        return (string)order.ToString();
    }
}


