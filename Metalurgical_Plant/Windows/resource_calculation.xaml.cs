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
using static Metalurgical_Plant.Windows.Calculator;
using Metalurgical;

namespace Metalurgical_Plant.Windows
{
    /// <summary>
    /// Логика взаимодействия для resource_calculation.xaml
    /// </summary>

    public static class Calculator
    {
        public enum Model { KR80, KR70, KR100 }

        public static void ShowProductivityPage(Model model, double tonnage)
        {
            resource_calculation productivityPage = new resource_calculation();
            productivityPage.SetData(model, tonnage);
            productivityPage.Show();
        }
    }

    public partial class resource_calculation : Window
    {
        public Model Model { get; private set; }
        public double Tonnage { get; private set; }
        public int Productivity { get; private set; }
        public double Remainder { get; private set; }

        public resource_calculation()
        {
            InitializeComponent();
        }

        public void SetData(Model model, double tonnage)
        {
            Model = model;
            Tonnage = tonnage;

            switch (Model)
            {
                case Model.KR80:
                    Productivity = (int)Math.Ceiling(tonnage * 15.567);
                    Remainder = tonnage * 15.567 - Productivity;
                    break;
                case Model.KR70:
                    Productivity = (int)Math.Ceiling(tonnage * 21.066);
                    Remainder = tonnage * 21.066 - Productivity;
                    break;
                case Model.KR100:
                    Productivity = (int)Math.Ceiling(tonnage * 11.23);
                    Remainder = tonnage * 11.23 - Productivity;
                    break;
            }

            DataContext = this;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(weightQuant.Text, out double distance)
                && (double.TryParse(weightQuant.Text, out double costPerKm)))
            {
                Calculate calculator = new Calculate(); 
                double result = calculator.CalculateLogisticsCost(distance, costPerKm); 
                resultTextBlock.Text = result.ToString("F2"); 
            }
            else
            {
                MessageBox.Show("Неверное значение", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
