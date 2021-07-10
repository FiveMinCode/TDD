using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDByExample.Model;
using TDDByExample.Service;

namespace TDDByExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public ICustomerService customer { get; set; }
        public CustomerController(ICustomerService _customer)
        {
            customer = _customer;
        }
        public List<Customer> GetCustomers(string lastName)
        {
            return customer.GetCustomers(lastName);
        }
    }
}
