using BusinessObject.Models;
using Reposioties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;

        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }

        public Customer GetAdminAccount()
        {
           return customerRepository.GetAdminAccount();
        }

        public List<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public Customer getCustomerByemail(string email)
        {
            return customerRepository.GetCustomerByemail(email);
        }

        public Customer GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }

        public void UpdateCustomer(Customer customer)
        {
           customerRepository.UpdateCustomer(customer);
        }
    }
}
