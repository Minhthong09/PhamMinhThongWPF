using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICustomerService
    {
        Customer getCustomerByemail(string email);
        Customer GetAdminAccount();
        List<Customer> GetAll();
        void UpdateCustomer(Customer customer);
        Customer GetCustomerById(int id);
    }
}
