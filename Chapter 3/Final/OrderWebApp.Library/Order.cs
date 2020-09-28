using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWebApp.Library
{
    public class Order
    {
        public Order()
        {
            Lines = new List<OrderLine>();
            OrderDate = DateTimeOffset.Now;
        }

        public Order(Customer customer) : this()
        {
            Customer = customer;
        }

        public void AddOrderLine()
        {
            Lines.Add(new OrderLine());
        }

        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public List<OrderLine> Lines { get; set; }

        public void AddOrderLine(Product product, int quantity)
        {
            OrderLine newLine = new OrderLine()
                {
                Product = product,
                Quantity = quantity
            };

            product.QuantityOnHand -= quantity;

            Lines.Add(newLine);
        }
    }
}
