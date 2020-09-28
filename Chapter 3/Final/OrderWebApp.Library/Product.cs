using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWebApp.Library
{
    public class Product
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
    }
}
