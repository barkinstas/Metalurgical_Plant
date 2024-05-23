using Metalurgical_Plant.Windows;
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

namespace Metalurgical_Plant
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Employees(object sender, RoutedEventArgs e)
        {
            Window_employees x = new Window_employees();
            x.Show();
            Close();
        }

        private void Button_resources(object sender, RoutedEventArgs e)
        {
            Window_resources x = new Window_resources();
            x.Show();
            Close();
        }

        private void Button_calculation(object sender, RoutedEventArgs e)
        {
            resource_calculation x = new resource_calculation();
            x.Show();
            Close();
        }

        private void Button_counting(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
