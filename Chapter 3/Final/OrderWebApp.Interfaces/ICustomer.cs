using OrderWebApp.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWebApp.Interfaces
{
    public interface ICustomer
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void AddOrUpdate(Customer customer);
        void Delete(int id);
    }
}
