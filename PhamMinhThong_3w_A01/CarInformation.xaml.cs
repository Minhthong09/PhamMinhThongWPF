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
using BusinessObject.Models;

namespace PhamMinhThong_3w_A01
{
    /// <summary>
    /// Interaction logic for CarInformation.xaml
    /// </summary>
    public partial class CarInformation : Window
    {
        private ICarService carService;
        public CarInformation()
        {
            InitializeComponent();
            carService = new CarService();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtgCustomer_Car.ItemsSource = carService.GetAll();
        }
    }
}
