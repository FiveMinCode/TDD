using System.Collections.Generic;
using TDDByExample.Model;

namespace TDDByExample.Service
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers(string lastName);
    }
}