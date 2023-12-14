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
    /// Interaction logic for CustomerInformation.xaml
    /// </summary>
    public partial class CustomerInformation : Window
    {
        private ICustomerService customerService;
        public CustomerInformation()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgCustomerInformation.ItemsSource = customerService.GetAll();
        }
    }
}
