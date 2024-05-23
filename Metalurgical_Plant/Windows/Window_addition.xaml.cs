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
    /// <summary>
    /// Логика взаимодействия для Window_addition.xaml
    /// </summary>
    public partial class Window_addition : Window
    {
        public Window_addition()
        {
            InitializeComponent();
        }

        private void TextBox_position(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_name(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_department(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            if (name.Text == string.Empty || department.Text == string.Empty || position.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                AppData.db.User.Add(new User() { FullName = name.Text, Department = department.Text, Position = position.Text});
                AppData.db.SaveChanges();

                new Window_employees().Show();
                this.Close();
            }
        }
    }
}
