using OrderWebApp.Library;
using System;
using System.Collections.Generic;

namespace OrderWebApp.Interfaces
{
    public interface IOrder
    {
        List<Order> GetAll();
        Order Get(int id);
        void AddOrUpdate(Order order);
        void Delete(int id);
    }
}
