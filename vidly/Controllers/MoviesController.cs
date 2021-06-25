using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vidly.Models;
using vidly.ModelsView;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movie = new movie() { Name = "shrek!" };
            var cx= new List<Customers>()
                {
                    new Customers { Name = " yasmeen" },
                    new Customers { Name = "abdallah" }
                };
            var movieCustomer = new MoviesCustomerView
            {
                Movies = movie,
                CustomerList =cx };
       
            return View(movieCustomer);
        }
        public IActionResult Edit(int id)
        {
            return Content("id " + id);
        }
        public IActionResult SortBy(int? id, string name)
        {
            if (!id.HasValue)
            {
                id = 1;
            }
            if (string.IsNullOrEmpty(name))
            {
                name = "this is the first one";
            }
            return Content(string.Format("hello the id is{0} and sort by{1}", id, name));
        }
       // [Route("Movies/multiargu/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public IActionResult multiargu(int year,int month)
        {
            return Content($"this is the year {year} and that the moth {month}");
        }
        
    }
}
