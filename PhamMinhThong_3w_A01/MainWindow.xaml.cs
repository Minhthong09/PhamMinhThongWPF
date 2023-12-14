using BusinessObject.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhamMinhThong_3w_A01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICustomerService customerService;
        public MainWindow()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = customerService.getCustomerByemail(txtUsername.Text.Trim());
            Customer admin = customerService.GetAdminAccount();
            if (customer != null && txtPassword.Password.Trim().Equals(customer.Password))
            {
                ProfileCustomer cus = new ProfileCustomer(customer);
                cus.Show();

            }
            else if (txtUsername.Text.Trim().Equals(admin.Email) && txtPassword.Password.Trim().Equals(admin.Password))
            {
                AdminPage ad = new AdminPage();
                ad.Show();
            }         
            else
            {
                MessageBox.Show("Login Fail");
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
