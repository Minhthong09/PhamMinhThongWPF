using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposioties
{
    public interface ICustomerRepository
    {
        Customer GetCustomerByemail(string email);
        Customer GetAdminAccount();
        public List<Customer> GetAll();
        public void UpdateCustomer(Customer customer);
        Customer GetCustomerById(int id);   
    }
}
