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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Metalurgical_Plant.Windows
{
    /// <summary>
    /// Логика взаимодействия для Window_employees.xaml
    /// </summary>
    public partial class Window_employees : Window
    {
        public Window_employees()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employeesGrid.ItemsSource = AppData.db.User.ToList();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            new Window_addition().Show();
            this.Close();
           

        }

        private void Button_delete(object sender, RoutedEventArgs e)
        {
            User selectedItem = (User)employeesGrid.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника");
            }
            else
            {
                List<User >u = AppData.db.User.Where(us => us.id == selectedItem.id).ToList();
                AppData.db.User.Remove(u[0]);
                AppData.db.SaveChanges();

                employeesGrid.ItemsSource = null;
                employeesGrid.ItemsSource = AppData.db.User.ToList();
            }
        }
    }
}
