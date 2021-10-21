using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "John" },
                new Customer { Id = 2, Name = "Stephen" }
            };

            var viewModel = new CustomerViewModel()
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "John" },
                new Customer { Id = 2, Name = "Stephen" }
            };

            var customer = customers.Find(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            Console.WriteLine(customer);

            return View(customer);
        }
    }
}