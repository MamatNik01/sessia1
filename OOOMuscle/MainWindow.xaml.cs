using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace OOOMuscle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vixod_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void gost_Click(object sender, RoutedEventArgs e)
        {
            Helper.user = null;
            MessageBox.Show("Вы зашли как гость!");
            Tovar tov = new Tovar();
            tov.Show();
            this.Hide();
        }

        private void vxod_Click(object sender, RoutedEventArgs e)
        {
            string log = login.Text;
            string Password = password.Text;
            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Введите все данные!");
                return;
            }
            else
            {
                var userss = new List<DBMuscle.User>();
                //List<DBMuscle.User> temp = Helper.db.User.Where(x => x.Login == login && x => x.Password == Password).ToList();
                userss = Helper.db.User.Where(p => p.Login == log && p.Password == Password).ToList();
                Helper.user = userss.FirstOrDefault();
                if (Helper.user == null)
                {
                    MessageBox.Show("Неверные данные!");
                    return;
                }
                else
                {
                    MessageBox.Show("Вы зашли как: " + Helper.user.Role.RoleName);
                    if (Helper.user.Role.RoleName == "Администратор")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (Helper.user.Role.RoleName == "Клиент")
                    {
                        Tovar tov = new Tovar();
                        tov.Show();
                        this.Hide();
                    }
                    else if (Helper.user.Role.RoleName == "Менеджер")
                    {
                        Manager manager = new Manager();
                        manager.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Helper.db = new DBMuscle.OOOMuscle();
        }
    }
}
