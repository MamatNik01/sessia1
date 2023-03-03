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
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            string connectionString2 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn2 = new SqlConnection(connectionString2);
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("Select ArticleID from Product", conn2);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                artic.Items.Add(dr2["ArticleID"]);
            }
            conn2.Close();
            artic.SelectedIndex = 0;

            string connectionString22 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn22 = new SqlConnection(connectionString22);
            conn22.Open();
            SqlCommand cmd22 = new SqlCommand("Select ProizvodilelName from Proizvoditel", conn22);
            SqlDataReader dr22 = cmd22.ExecuteReader();
            while (dr22.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                proiz.Items.Add(dr22["ProizvodilelName"]);
            }
            conn22.Close();
            proiz.SelectedIndex = 0;

            string connectionString222 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn222 = new SqlConnection(connectionString222);
            conn222.Open();
            SqlCommand cmd222 = new SqlCommand("Select PostavshikName from Postavshik", conn222);
            SqlDataReader dr222 = cmd222.ExecuteReader();
            while (dr222.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                post.Items.Add(dr222["PostavshikName"]);
            }
            conn222.Close();
            post.SelectedIndex = 0;

            string connectionString2222 = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn2222 = new SqlConnection(connectionString2222);
            conn2222.Open();
            SqlCommand cmd2222 = new SqlCommand("Select CategoryName from Category", conn2222);
            SqlDataReader dr2222 = cmd2222.ExecuteReader();
            while (dr2222.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                categ.Items.Add(dr2222["CategoryName"]);
            }
            conn2222.Close();
            categ.SelectedIndex = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void zena_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void skidka_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void kol_vo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }

        private void artic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int log = Convert.ToInt32(artic.SelectedValue.ToString());
                var userss = new List<DBMuscle.Product>();
                //zak.Content = log;
                userss = Helper.db.Product.Where(p => p.ArticleID == log).ToList();
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
                    string zena = Helper.product.Cost.ToString();
                    double chena = Math.Round(Convert.ToDouble(zena), 2);
                    string sale = Helper.product.Sale.ToString();
                    list.Items.Add("Цена без скидки: " + chena + " руб.");
                    list.Items.Add("Скидка: " + sale + " %");
                    double all = (1 - Convert.ToDouble(sale) / 100) * Convert.ToDouble(zena);
                    double okr = Math.Round(all, 2);
                    list.Items.Add("Цена со скидкой: " + okr + " руб.");
                    string proiz = Helper.product.Proizvoditel.ProizvodilelName;
                    list.Items.Add("Производитель: " + proiz);
                    string postav = Helper.product.Postavshik.PostavshikName;
                    list.Items.Add("Поставщик: " + postav);
                    string sostav = Helper.product.Category.CategoryName;
                    list.Items.Add("Категория: " + sostav);
                    int count = Convert.ToInt32(Helper.product.Count.ToString());
                    list.Items.Add("Количество: " + count);
                    string desc = Helper.product.Description.ToString();
                    list.Items.Add("Описание: " + desc);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ima.Text) || string.IsNullOrEmpty(skidka.Text) || string.IsNullOrEmpty(zena.Text) || string.IsNullOrEmpty(kol_vo.Text) || string.IsNullOrEmpty(opisanie.Text))
                {
                    MessageBox.Show("Заполните все данные!");
                }
            else
            {
                try
                {
                    Random rand2 = new Random();
                    int rand22 = rand2.Next(100000000, 999999999);
                    DBMuscle.Product product = new DBMuscle.Product();
                    product = new DBMuscle.Product();
                    product.ArticleID = rand22;
                    product.Name = ima.Text;
                    product.Cost = Convert.ToInt32(zena.Text);
                    product.Sale = Convert.ToInt32(skidka.Text);
                    product.ProizvoditelID = (int)proiz.SelectedIndex + 1;
                    product.PostavshikID = (int)post.SelectedIndex + 1;
                    product.CategoryID = (int)categ.SelectedIndex + 1;
                    product.Count = Convert.ToInt32(kol_vo.Text);
                    product.Description = opisanie.Text;
                    product.Photo = "-";
                    Helper.db.Product.Add(product);
                    Helper.db.SaveChanges();
                    MessageBox.Show("Товар добавлен!");
                    Admin admin = new Admin();
                    admin.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так!");
                }
            }
        }

        private void redakt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ima.Text) || string.IsNullOrEmpty(skidka.Text) || string.IsNullOrEmpty(zena.Text) || string.IsNullOrEmpty(kol_vo.Text) || string.IsNullOrEmpty(opisanie.Text))
            {
                MessageBox.Show("Заполните все данные!");
            }
            else
            {
                int n = Convert.ToInt32(skidka.Text);
                if (n == 0)
                {
                    MessageBox.Show("Скидка не может быть 0!!!");
                }
                if (n >= 100)
                {
                    MessageBox.Show("Больше 100% скидка!!!");
                }
                else
                {
                    int order2 = Convert.ToInt32(artic.SelectedValue.ToString());   //Артикул для поиска или добавления
                    DBMuscle.Product product = null;      //Обрабатываемый товар						//Редактирование товара
                    product = Helper.db.Product.Find(order2); //Найти товар по артиклю
                    product.Name = ima.Text;
                    product.Cost = Convert.ToInt32(zena.Text);
                    product.Sale = Convert.ToInt32(skidka.Text);
                    product.ProizvoditelID = (int)proiz.SelectedIndex + 1;
                    product.PostavshikID = (int)post.SelectedIndex + 1;
                    product.CategoryID = (int)categ.SelectedIndex + 1;
                    product.Count = Convert.ToInt32(kol_vo.Text);
                    product.Description = opisanie.Text;
                    product.Photo = "-";
                    try
                    {
                        Helper.db.SaveChanges();
                        MessageBox.Show("Информация в БД успешно обновлена");
                        list.Items.Clear();
                        artic.SelectedIndex = 0;
                    }
                    catch
                    {
                        MessageBox.Show("При обновлении данных в БД возникла ошибка!");
                        return;
                    }
                }
            }
        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            int order2 = Convert.ToInt32(artic.SelectedValue.ToString());   //Артикул для поиска или добавления
            DBMuscle.Product product = null;      //Обрабатываемый товар						//Редактирование товара
            product = Helper.db.Product.Find(order2); //Найти товар по артиклю
            try
            {
                Helper.db.Product.Remove(product);
                Helper.db.SaveChanges();
                MessageBox.Show("Товар удалён!!!");
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
                return;
            }
        }
    }
}
