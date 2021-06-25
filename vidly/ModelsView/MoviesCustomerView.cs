using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vidly.Models;

namespace vidly.ModelsView
{
    public class MoviesCustomerView
    {
        public movie Movies { get; set; }
        public List<Customers> CustomerList { get; set; }
    }
}
