using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;

        public CustomerDAO()
        {

        }
        public static CustomerDAO getInstance()
        {

            if (instance == null)
            {
                instance = new CustomerDAO();
            }
            return instance;
        }
        public Customer GetCustomerByemail(string email)
        {
            var dbContent = new FUCarRentingManagementContext();
            return dbContent.Customers.SingleOrDefault(m => m.Email.Equals(email)); 
        }
        public Customer GetAdminAccount()
        {
            var dbContent = new FUCarRentingManagementContext();
            return dbContent.GetAccount();
        }
        public List<Customer> GetAll()
        {
            var dbContent = new FUCarRentingManagementContext();
            return dbContent.Customers.ToList();
        }
        public void UpdateCustomer(Customer customer)
        {
            var dbContent = new FUCarRentingManagementContext();     
            Customer cus = GetCustomerByemail(customer.Email);
            if (cus != null)
            {
               dbContent.Customers.Update(customer);
               dbContent.SaveChanges();
            }

        }
        public Customer GetCustomerById(int id)
        {
            var dbContent = new FUCarRentingManagementContext();
            return dbContent.Customers.Where(m => m.CustomerId.Equals(id)).FirstOrDefault();
        }
    }
}
