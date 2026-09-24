using ConsoleApp24.models;

namespace ConsoleApp24.interfaces;

public interface IOrderService<T> where T : Order, IEntity
{
    Task AddOrderAsync(T order);
    Task<T> GetOrderByIdAsync(int id);
    Task ProcessOrdersConcurrentlyAsync();
}
