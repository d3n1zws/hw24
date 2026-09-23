namespace ConsoleApp24.models;

using ConsoleApp24.interfaces;
using ConsoleApp24.records;
using ConsoleApp24.enums;
internal class Order: IEntity
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
    public static implicit operator string(Order order)
    {
        return Order.ToString();
    }
    public override string ToString()
    {
        return $""
    }
}
//Implicit / Explicit Operator: Order obyektini decimal-a cast etdikdə TotalAmount-u qaytarmalıdır (Explicit). string-ə cast etdikdə isə sifariş haqqında xülasə mətn qaytarmalıdır (Implicit).

