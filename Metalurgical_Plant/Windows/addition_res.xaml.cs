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
using System.Xml.Linq;

namespace Metalurgical_Plant.Windows
{
    /// <summary>
    /// Логика взаимодействия для addition_res.xaml
    /// </summary>
    public partial class addition_res : Window
    {
        public addition_res()
        {
            InitializeComponent();
        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            if (kr70.Text == string.Empty || kr80.Text == string.Empty || kr100.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                AppData.db.Resources.Add(new Resources() { kr70 = int.Parse(kr70.Text), kr80 = int.Parse(kr80.Text), kr100 = int.Parse(kr100.Text) });
                AppData.db.SaveChanges();

                new Window_resources().Show();
                this.Close();
            }
        }
    }
}
