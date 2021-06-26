using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var cx = ListOfCustomers();
         return View(cx);
        }
        public IActionResult ListOfCustomers()
        {
            List<Customers> cxs= new List<Customers>
            {
 
                new Customers { Id = 1, Name = "John Smith" },
                new Customers { Id = 2, Name = "Mary Williams" }
            };
            return View(cxs);
        }
        

    }
}
