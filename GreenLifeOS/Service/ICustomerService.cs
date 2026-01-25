using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface ICustomerService
    {
        Customer AddNewCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Customer UpdateCustomer(Customer customer);
        bool DeleteCustomer(int id);

    }
}
