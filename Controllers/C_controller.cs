using Microsoft.AspNetCore.Mvc;
using OnlineBankingWeb.Models;
using System.Collections.Generic;

namespace OnlineBankingWeb.Controllers
{
    public class CustomerController : Controller
    {
        // Temporary in-memory storage
        private static List<Customer> customers = new List<Customer>();

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            customer.Id = customers.Count + 1;
            customers.Add(customer);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View(customers);
        }
    }
}
