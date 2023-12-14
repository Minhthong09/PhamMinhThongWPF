using BusinessObject.Models;
using DAOs;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhamMinhThong_3w_A01
{
    /// <summary>
    /// Interaction logic for ProfileCustomer.xaml
    /// </summary>
    public partial class ProfileCustomer : Window
    {
        private ICustomerService _customerService = new CustomerService();
        private Customer customerinformation;
                
        public ProfileCustomer(Customer customer)
        {
            InitializeComponent();
            customerinformation = customer;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cus_Name.Text = customerinformation.CustomerName;
            Cus_Phone.Text = customerinformation.Telephone;
            Cus_Email.Text = customerinformation.Email;
            Cus_Birthday.Text = customerinformation.CustomerBirthday.ToString();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            
            var customerInformation = new CustomerInformation();
            if (customerinformation != null)

            {
                customerinformation.CustomerName = Cus_Name.Text;
                customerinformation.Telephone = Cus_Phone.Text;
                customerinformation.Email = Cus_Email.Text;
                customerinformation.CustomerBirthday = Cus_Birthday.SelectedDate.Value;
                _customerService.UpdateCustomer(customerinformation);
                MessageBox.Show("Update Success" , "Conformation" , MessageBoxButton.OK);
                Window_Loaded(sender, e);
            } 
            else
            {
                MessageBox.Show("Invalid");
            }
           

        }
    }
}
