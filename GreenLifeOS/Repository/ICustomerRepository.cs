using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface ICustomerRepository
    {
        Customer AddNewCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        bool DeleteCustomer(int id);

    }
}
