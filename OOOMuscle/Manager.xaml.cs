using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace OOOMuscle
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select OrderID from [Order]", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                order.Items.Add(dr["OrderID"]);
            }
            conn.Close();

            string connectionString2 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn2 = new SqlConnection(connectionString2);
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("Select AddressName from [Address]", conn2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                adress.Items.Add(dr2["AddressName"]);
            }
            conn2.Close();

            string connectionString3 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn3 = new SqlConnection(connectionString3);
            conn3.Open();
            SqlCommand cmd3 = new SqlCommand("Select StatusName from [Status]", conn3);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                status.Items.Add(dr3["StatusName"]);
            }
            conn3.Close();
            order.SelectedIndex = 0;
            adress.SelectedIndex = 0;
            status.SelectedIndex = 0;
        }

        private void zamena_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(fiooo.Text) || (string.IsNullOrEmpty(Kod.Text)))
            {
                MessageBox.Show("Пустые данные!");
            }
            else
            {
                int n = Convert.ToInt32(Kod.Text);
                if (n <= 99)
                {
                    MessageBox.Show("Трехзначное число!");
                }
                else
                {
                    int order2 = Convert.ToInt32(order.SelectedValue.ToString());   //Артикул для поиска или добавления
                    DBMuscle.Order ord = null;      //Обрабатываемый товар						//Редактирование товара
                    ord = Helper.db.Order.Find(order2); //Найти товар по артиклю
                    ord.OrderID = order2;
                    ord.DataZakaza = Convert.ToDateTime(N.Content);
                    ord.DataDostavki = Convert.ToDateTime(D.Content);
                    ord.FIO = fiooo.Text;
                    ord.Code = Convert.ToInt32(Kod.Text);
                    ord.AddressID = (int)adress.SelectedIndex + 1;
                    ord.StatusID = (int)status.SelectedIndex + 1;
                    try
                    {
                        Helper.db.SaveChanges();
                        MessageBox.Show("Информация в БД успешно обновлена");
                        list.Items.Clear();
                        order.SelectedIndex = 0;
                    }
                    catch
                    {
                        MessageBox.Show("При обновлении данных в БД возникла ошибка!");
                        return;
                    }
                }
            }
        }

        private void order_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int log = Convert.ToInt32(order.SelectedValue.ToString());
            var userss = new List<DBMuscle.Order>();
            //zak.Content = log;
            userss = Helper.db.Order.Where(p => p.OrderID == log).ToList();
            Helper.order = userss.FirstOrDefault();
            if (Helper.order == null)
            {
                MessageBox.Show("Нет данных!!!");
                return;
            }
            else
            {
                list.Items.Clear();
                int nam = Convert.ToInt32(Helper.order.OrderID.ToString());
                list.Items.Add("Номер заказа: " + nam);
                string nach = Helper.order.DataZakaza.ToShortDateString();
                list.Items.Add("Дата заказа: " + nach);
                N.Content = nach;
                string kon = Helper.order.DataDostavki.ToShortDateString();
                list.Items.Add("Дата доставки: " + kon);
                D.Content = kon;
                string FIO = Helper.order.FIO.ToString();
                list.Items.Add("ФИО: " + FIO);
                fiooo.Text = FIO;
                string address = Helper.order.Address.AddressName;
                list.Items.Add("Адрес: " + address);
                int code = Convert.ToInt32(Helper.order.Code.ToString());
                list.Items.Add("Код: " + code);
                Kod.Text = Convert.ToString(code);
                string status = Helper.order.Status.StatusName;
                list.Items.Add("Статус: " + status);
            }
        }

        private void Kod_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Kod_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void Kod_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(Kod.Text))
            {

            }
            else
            {
                int n = Convert.ToInt32(Kod.Text);
                if (n >= 1000)
                {
                    MessageBox.Show("Трехзначное число!");
                    Kod.Text = "";
                }
            }

        }
    }
}
