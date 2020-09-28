using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderWebApp.Interfaces;
using OrderWebApp.Library;
using OrderWebApp.Models;

namespace OrderWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomer customerDataAccess;
        private readonly IProduct productDataAccess;

        public HomeController(ICustomer customerDataAccess, IProduct productDataAccess)
        {
            this.customerDataAccess = customerDataAccess;
            this.productDataAccess = productDataAccess;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Customers()
        {
            List<Customer> customers = customerDataAccess.GetAll();

            return View(customers);
        }

        public IActionResult CustomerEdit(int id)
        {
            Customer customer = customerDataAccess.Get(id);

            return View(customer);
        }

        public IActionResult CustomerDelete(int id)
        {
            customerDataAccess.Delete(id);
            return new RedirectResult("Customers");
        }

        public IActionResult Products()
        {
            List<Product> products = productDataAccess.GetAll();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
