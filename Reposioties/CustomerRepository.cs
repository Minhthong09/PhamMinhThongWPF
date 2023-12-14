using BusinessObject.Models;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposioties
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerByemail(string email)=> CustomerDAO.getInstance().GetCustomerByemail(email);
        public Customer GetAdminAccount() => CustomerDAO.getInstance().GetAdminAccount();

        public List<Customer> GetAll() => CustomerDAO.getInstance().GetAll();

        public void UpdateCustomer(Customer customer)
        {
            CustomerDAO.getInstance().UpdateCustomer(customer);
        }

        public Customer GetCustomerById(int id)=> CustomerDAO.getInstance().GetCustomerById(id);



    }
}
