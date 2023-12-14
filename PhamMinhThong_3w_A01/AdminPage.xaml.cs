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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          CustomerInformation customerInformation = new CustomerInformation();
            customerInformation.Show();        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CarInformation carInformation = new CarInformation();
            carInformation.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RentingInformation rentingInformation = new RentingInformation();
            rentingInformation.Show();
        }
    }
}
