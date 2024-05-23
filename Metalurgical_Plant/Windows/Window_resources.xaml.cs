using Metalurgical_Plant.DBase;
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

namespace Metalurgical_Plant.Windows
{
    public partial class Window_resources : Window
    {
        public Window_resources()
        {
            InitializeComponent();
        }

        private void Window2_Loaded(object sender, RoutedEventArgs e)
        {
            resourcesGrid.ItemsSource = AppData.db.Resources.ToList();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            new addition_res().Show();
            this.Close();
        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            Resources selectedItem = (Resources)resourcesGrid.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Выберите поле");
            }
            else
            {
                List<Resources> u = AppData.db.Resources.Where(us => us.id == selectedItem.id).ToList();
                AppData.db.Resources.Remove(u[0]);
                AppData.db.SaveChanges();

                resourcesGrid.ItemsSource = null;
                resourcesGrid.ItemsSource = AppData.db.Resources.ToList();
            }
        }
    }
}
