using OrderWebApp.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWebApp.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAll();
        Product Get(int id);
        void AddOrUpdate(Product product);
        void Delete(int id);
    }
}
