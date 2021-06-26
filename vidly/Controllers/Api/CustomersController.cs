using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using vidly.Models;

namespace vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomersController : ControllerBase
    {

        private ModelDbContex _context;
        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<DbContext> _optionsBuilder;


        public CustomersController(IConfiguration configuration)
        {
            _configuration = configuration;
            _optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            _connectionString = _configuration.GetConnectionString("Default");
            _optionsBuilder.UseSqlServer(_connectionString);
            _context = new ModelDbContex(_optionsBuilder.Options);



        }

        //api/ get
        public IEnumerable<Customers> Get() {

            return _context.customers.ToList();
        }
        //api/get/1
        public Customers GetCustomerById(int id)
        {
            Customers customer = _context.customers.SingleOrDefault(i => i.Id == id);
            if (customer == null)
                throw new HttpRequestException();
            return customer;
        }

        //api/post
        [HttpPost]
        public void CreateCustomer(Customers customer)
        {
            if (!ModelState.IsValid)
                throw new Exception();
            _context.customers.Add(customer);
            _context.SaveChanges();


        }
        //api/put
        [HttpPut]
        public void UpdateCustomer(int id, Customers customer)
        {
            Customers cx = _context.customers.SingleOrDefault(i => i.Id == id);
            if (!ModelState.IsValid)
                throw new Exception();
            cx.Id = customer.Id;
            cx.Name = customer.Name;
            cx.MemberShipType = customer.MemberShipType;
            cx.IsSubcribedToNewsLetter = customer.IsSubcribedToNewsLetter;
            _context.SaveChanges();
        }
        //api/delete
        [HttpDelete]
        public void Delete(int id)
        {
            Customers customer = _context.customers.SingleOrDefault(i => i.Id == id);
            if (customer == null)
                throw new HttpRequestException();
            _context.customers.Remove(customer);
            _context.SaveChanges();

        }

        }
}
