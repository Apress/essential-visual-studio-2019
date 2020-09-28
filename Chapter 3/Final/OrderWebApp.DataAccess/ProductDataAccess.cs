using OrderWebApp.Interfaces;
using OrderWebApp.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderWebApp.DataAccess
{
    public class ProductDataAccess : IProduct
    {
        private static List<Product> DataList;

        static ProductDataAccess()
        {
            DataList = new List<Product>()
            {
                new Product() {Id = 1, Number = "A-123", Description = "First Description", Cost = 10.99m, Price = 15.75m, QuantityOnHand = 100},
                new Product() {Id = 2, Number = "A-234", Description = "Second Description", Cost = 11.49m, Price = 17.99m, QuantityOnHand = 200},
                new Product() {Id = 3, Number = "A-345", Description = "Third Description", Cost = 3.99m, Price = 5.49m, QuantityOnHand = 350},
                new Product() {Id = 4, Number = "A-456", Description = "Fourth Description", Cost = 15.45m, Price = 25.25m, QuantityOnHand = 50},
                new Product() {Id = 5, Number = "A-567", Description = "Fifth Description", Cost = 7.87m, Price = 9.99m, QuantityOnHand = 423},
                new Product() {Id = 6, Number = "A-678", Description = "Sixth Description", Cost = 8.29m, Price = 13.99m, QuantityOnHand = 112},
                new Product() {Id = 7, Number = "A-789", Description = "Seventh Description", Cost = 4.53m, Price = 9.25m, QuantityOnHand = 145},
                new Product() {Id = 8, Number = "A-890", Description = "Eighth Description", Cost = 6.68m, Price = 8.75m, QuantityOnHand = 321},
                new Product() {Id = 9, Number = "B-321", Description = "Ninth Description", Cost = 14.39m, Price = 28.29m, QuantityOnHand = 173},
                new Product() {Id = 10, Number = "B-432", Description = "Tenth Description", Cost = 9.79m, Price = 12.75m, QuantityOnHand = 129},
                new Product() {Id = 11, Number = "B-543", Description = "Eleventh Description", Cost = 15.29m, Price = 22.99m, QuantityOnHand = 311}
            };
        }
        public List<Product> GetAll()
        {
            return DataList;
        }

        public Product Get(int id)
        {
            Product result = DataList.Find(c => c.Id == id);
            if (result == null)
            {
                throw new ArgumentOutOfRangeException($"No product exists with an Id of {id}");
            }

            return result;
        }

        public void AddOrUpdate(Product product)
        {
            Product existingProduct = DataList.Find(c => c.Id == product.Id);
            if (existingProduct == null)
            {
                DataList.Add(product);
            }
            else
            {
                existingProduct.Number = product.Number;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Cost = product.Cost;
                existingProduct.QuantityOnHand = product.QuantityOnHand;
            }
        }

        public void Delete(int id)
        {
            Product existingProduct = DataList.Find(c => c.Id == id);
            if (existingProduct == null)
            {
                throw new ArgumentOutOfRangeException($"No product exists with an Id of {id}");
            }
            else
            {
                DataList.Remove(existingProduct);
            }
        }
    }
}
