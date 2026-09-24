using ConsoleApp24.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24.models;

public class OrderProcessor<T> : IOrderService<T>, where T : Order, IEntity
{
    List<T> list = new List<T>();
    Task AddOrderAsync(T order);
    Task<T> GetOrderByIdAsync(int id);
    Task ProcessOrdersConcurrentlyAsync();
}
