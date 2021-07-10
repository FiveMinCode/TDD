using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDByExample.Model;

namespace TDDByExample.Service
{
    public class CustomerService:ICustomerService
    {
        public List<Customer> GetCustomers(string lastName)
        {
            var customer = new Customer
            {
                FirstName = "Jack",
                LastName = "Sparrow"
            };
            var customerList = new List<Customer>();
            customerList.Add(customer);
            return customerList.Where(t => t.LastName == lastName).ToList();
        }
    }
}
