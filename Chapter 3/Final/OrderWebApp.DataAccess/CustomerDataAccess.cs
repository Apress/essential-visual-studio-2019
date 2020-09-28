using OrderWebApp.Interfaces;
using OrderWebApp.Library;
using System;
using System.Collections.Generic;

namespace OrderWebApp.DataAccess
{
    public class CustomerDataAccess : ICustomer
    {
        private static List<Customer> DataList;
        
        static CustomerDataAccess()
        {
            DataList = new List<Customer>()
            {
                new Customer() {Id = 1, Name = "Acme Manufacturing"},
                new Customer() {Id = 2, Name = "Beeline Development"},
                new Customer() {Id = 3, Name = "Co-operative Research"},
                new Customer() {Id = 4, Name = "Delta Productions"},
                new Customer() {Id = 5, Name = "East Street Construction"},
                new Customer() {Id = 6, Name = "Fleet Delivery"},
                new Customer() {Id = 7, Name = "Grommets 'R US"},
                new Customer() {Id = 8, Name = "Humour, Inc"},
                new Customer() {Id = 9, Name = "Iceotropic"},
                new Customer() {Id = 10, Name = "Johnson Soda"},
                new Customer() {Id = 11, Name = "Krafty Kat Kibble"},
                new Customer() {Id = 12, Name = "Logan Locks"},
                new Customer() {Id = 13, Name = "Mighty, Mighty Bosstones"},
                new Customer() {Id = 14, Name = "Noontime Nappies"},
                new Customer() {Id = 15, Name = "Orange You Happier Now"},
                new Customer() {Id = 16, Name = "Parimeter Mathematics"},
                new Customer() {Id = 17, Name = "Queen Anne's Lace Clothing"},
                new Customer() {Id = 18, Name = "Rocket Men"},
                new Customer() {Id = 19, Name = "Snicker's Dog Walking"},
                new Customer() {Id = 20, Name = "Twix Garbage Collection"},
                new Customer() {Id = 21, Name = "Ultra Trail Design"},
                new Customer() {Id = 22, Name = "Vertical Planes"},
                new Customer() {Id = 23, Name = "Wide Mouth Frog Entertainment"},
                new Customer() {Id = 24, Name = "Xtra Fresh Mints"},
                new Customer() {Id = 25, Name = "Youth Fashion"},
                new Customer() {Id = 26, Name = "Zero Tolerance Boring"}
            };
        }
        public List<Customer> GetAll()
        {
            return DataList;
        }

        public Customer Get(int id)
        {
            Customer result = DataList.Find(c => c.Id == id);
            if (result == null)
            {
                throw new ArgumentOutOfRangeException($"No customer exists with an Id of {id}");
            }

            return result;
        }

        public void AddOrUpdate(Customer customer)
        {
            Customer existingCustomer = DataList.Find(c => c.Id == customer.Id);
            if (existingCustomer == null)
            {
                DataList.Add(customer);
            }
            else
            {
                existingCustomer.Name = customer.Name;
            }
        }

        public void Delete(int id)
        {
            Customer existingCustomer = DataList.Find(c => c.Id == id);
            if (existingCustomer == null)
            {
                throw new ArgumentOutOfRangeException($"No customer exists with an Id of {id}");
            }
            else
            {
                DataList.Remove(existingCustomer);
            }
        }
    }
}
