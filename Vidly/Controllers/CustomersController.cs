using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{

    public class CustomersController : Controller {
        private List<Customer> customers = new List<Customer>() {
            new Customer() {Name = "Ilya", Id = 1},
            new Customer() {Name = "Masha", Id = 2},
            new Customer() {Name = "Vasya", Id = 3}
        };
        // GET: Customers
        [Route("Customers")]
        public ActionResult Customers() {
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id) {
            var viewModel = new CustomerViewModel() {
                Customer = customers[id-1]
            };
            return View(viewModel);
        }
    }

        
}