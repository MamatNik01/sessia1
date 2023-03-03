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
using System.Windows.Shapes;

namespace OOOMuscle
{
    /// <summary>
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Window
    {
        public Zakaz()
        {
            InitializeComponent();
            string connectionString2 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn2 = new SqlConnection(connectionString2);
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("Select AddressName from Address", conn2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                address.Items.Add(dr2["AddressName"]);
            }
            conn2.Close();
            address.SelectedIndex = 0;
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            int random = Convert.ToInt32(order222.Content);
            var userss = new List<DBMuscle.Sostav>();
            //zak.Content = log;
            userss = Helper.db.Sostav.Where(p => p.OrderID == random).ToList();
            Helper.sostav = userss.FirstOrDefault();
            if (Helper.sostav == null)
            {
                MessageBox.Show("Возьмите товар!");
                return;
            }
            else
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void spisok_Click(object sender, RoutedEventArgs e)
        {
            Tovar tovar = new Tovar();
            tovar.Show();
            this.Close();
        }

        private void Zakaz1_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select Name from Product", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                name.Items.Add(dr["Name"]);
            }
            conn.Close();
            kolvo.SelectedIndex = 0;
            name.SelectedIndex = 0;
            string nachalo = DateTime.Now.ToString("yyyy-MM-dd");
            nach.Content = nachalo;
            var addedDate = DateTime.Now.Date.AddDays(7);
            konec.Content = addedDate.ToString("yyyy-MM-dd");
            Random rand = new Random();
            int random = rand.Next(1, 1000000000);
            order222.Content = Convert.ToString(random);
            dobavit.IsEnabled = false;
            kolvo.IsEnabled = false;
            nazad.IsEnabled = false;
        }

        private void name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string log = name.SelectedValue.ToString();
            var userss = new List<DBMuscle.Product>();
            //zak.Content = log;
            userss = Helper.db.Product.Where(p => p.Name == log).ToList();
            Helper.product = userss.FirstOrDefault();
            if (Helper.product == null)
            {
                MessageBox.Show("Нет данных!!!");
                return;
            }
            else
            {
                list.Items.Clear();
                string nam = Helper.product.Name.ToString();
                list.Items.Add("Имя: " + nam);
                string proiz = Helper.product.Proizvoditel.ProizvodilelName;
                list.Items.Add("Производитель: " + proiz);
                string zena = Helper.product.Cost.ToString();
                double chena = Math.Round(Convert.ToDouble(zena), 2);
                string sale = Helper.product.Sale.ToString();
                list.Items.Add("Цена без скидки: " + chena + " руб.");
                list.Items.Add("Скидка: " + sale + " %");
                double all = (1 - Convert.ToDouble(sale) / 100) * Convert.ToDouble(zena);
                double okr = Math.Round(all, 2);
                list.Items.Add("Цена со скидкой: " + okr + " руб.");
            }
        }
        // private DataTable inf;
        private void dobavit_Click(object sender, RoutedEventArgs e)
        {
            string log = name.SelectedValue.ToString();
            var userss = new List<DBMuscle.Product>();
            //zak.Content = log;
            userss = Helper.db.Product.Where(p => p.Name == log).ToList();
            Helper.product = userss.FirstOrDefault();
            if (Helper.product == null)
            {
                MessageBox.Show("Нет данных!!!");
                return;
            }
            else
            {
                string nam = Helper.product.Name.ToString();
                var item = (ComboBoxItem)kolvo.SelectedValue;
                var kol = (string)item.Content;
                //string kol = kolvo.SelectedValue.ToString();
                DataTable dt = null;
                if (datagrid.ItemsSource == null)
                {
                    dt = new DataTable();
                    dt.Columns.Add("Имя");
                    dt.Columns.Add("Количество");
                    dt.Rows.Add(nam, kol);
                    datagrid.Items.Clear();
                    datagrid.ItemsSource = dt.AsDataView();
                }
                else
                {
                    dt = (datagrid.ItemsSource as DataView).Table;
                    dt.Rows.Add(nam, kol);
                }
            }
            try
            {
                Random rand = new Random();
                int random = rand.Next(1, 1000000000);
                var item2 = (ComboBoxItem)kolvo.SelectedValue;
                var kol2 = (string)item2.Content;
                var useress = new List<DBMuscle.Product>();
                userss = Helper.db.Product.Where(p => p.Name == log).ToList();
                Helper.product = userss.FirstOrDefault();
                if (Helper.product == null)
                {
                    MessageBox.Show("Нет данных!!!");
                    return;
                }
                else
                {
                    try
                    {
                        int article = Helper.product.ArticleID;
                        DBMuscle.Sostav sostav = new DBMuscle.Sostav();
                        //DBMuscle.Sostav sostav = new DBMuscle.Sostav();
                        sostav = new DBMuscle.Sostav();
                        // sostav = new DBMuscle.Sostav();
                        //int random = Convert.ToInt32(rand);
                        //int random3 = Convert.ToInt32(rand3);
                        // int random = Convert.ToInt32(order);
                        int random2 = Convert.ToInt32(order222.Content);
                        sostav.NomerID = random;
                        sostav.OrderID = random2;
                        sostav.ArticleID = article;
                        sostav.Count = Convert.ToInt32(kol2);
                        Helper.db.Sostav.Add(sostav);
                        Helper.db.SaveChanges();
                        MessageBox.Show("Товар добавлен!");
                    }
                    catch
                    {
                        MessageBox.Show("Что-то пошло не так!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }


        private void oformit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rand2 = new Random();
                int rand22 = rand2.Next(100, 999);
                // Random rand3 = new Random();
                // rand3.Next(1, 1000000000);
                string nachalo = DateTime.Now.ToString("yyyy-MM-dd");
                nach.Content = nachalo;
                var addedDate = DateTime.Now.Date.AddDays(7);
                konec.Content = addedDate.ToString("yyyy-MM-dd");
                DBMuscle.Order order = new DBMuscle.Order();
                //DBMuscle.Sostav sostav = new DBMuscle.Sostav();
                order = new DBMuscle.Order();
            // sostav = new DBMuscle.Sostav();
            //int random = Convert.ToInt32(rand);
            //int random3 = Convert.ToInt32(rand3);
            // int random = Convert.ToInt32(order);
            int random = Convert.ToInt32(order222.Content);
                order.OrderID = random;
                order.DataZakaza = Convert.ToDateTime(nachalo);
                order.DataDostavki = Convert.ToDateTime(addedDate);
                order.FIO = "-";
                order.Code = rand22;
                order.AddressID = (int)address.SelectedIndex + 1;
                order.StatusID = 1;
                Helper.db.Order.Add(order);
                Helper.db.SaveChanges();
                MessageBox.Show("Заказ выполнен! Выбирайте товары!");
                dobavit.IsEnabled = true;
                kolvo.IsEnabled = true;
                nazad.IsEnabled = true;
                spisok.IsEnabled = false;
                address.IsEnabled = false;
                oformit.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }
        private void kolvo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
