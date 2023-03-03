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
    /// Логика взаимодействия для Tovar.xaml
    /// </summary>
    public partial class Tovar : Window
    {
       // string pathExe = Application.StartupPath;		//Путь к exe без имени файла
        int filterDiscount, filterCategory; 			//Фильтр по скидке и категории
        string sort;						//Направление сортировки
        int countAll, countFilter;			//Количество всех записей и после фильтрации
        string search;						//Строка поиска
        double[,] arrayDiscount = new double[,] { { 0, 100 }, { 0, 10 }, { 11, 14 }, { 15, 100 } };

        string cat;
        public Tovar()
        {
            InitializeComponent();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = poisk.Text;
            string group = "";
            int gr1 = sortirovka.SelectedIndex;
            string cat = "";
            int c1 = kategoria.SelectedIndex;
            if (gr1 == 0)
            {
                group = "ASC";
            }
            else if (gr1 == 1)
            {
                group = "DESC";
            }
            if (c1 == 0)
            {
                ShowInfo();
                return;
            }
            else if (c1 == 1)
            {
                cat = "Тренажер";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 2)
            {
                cat = "Спортивный снаряд";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 3)
            {
                cat = "Тяжелая атлетика";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 4)
            {
                cat = "Гимнастический снаряд";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
        }

        private void sortirovka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = poisk.Text;
            string group = "";
            int gr1 = sortirovka.SelectedIndex;
            string cat = "";
            int c1 = kategoria.SelectedIndex;
            if (gr1 == 0)
            {
                group = "ASC";
            }
            else if (gr1 == 1)
            {
                group = "DESC";
            }
            if (c1 == 0)
            {
                ShowInfo();
                return;
            }
            else if (c1 == 1)
            {
                cat = "Тренажер";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 2)
            {
                cat = "Спортивный снаряд";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 3)
            {
                cat = "Тяжелая атлетика";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 4)
            {
                cat = "Гимнастический снаряд";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
        }
        /// <summary>
        /// Не буду брать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void kategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = poisk.Text;
            string group = "";
            int gr1 = sortirovka.SelectedIndex;
            string cat = "";
            int c1 = kategoria.SelectedIndex;
            if (gr1 == 0)
            {
                group = "ASC";
            }
            else if (gr1 == 1)
            {
                group = "DESC";
            }
            if (c1 == 0)
            {
                ShowInfo();
                return;
            }
            else if (c1 == 1)
            {
                cat = "Тренажер";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 2)
            {
                cat = "Спортивный снаряд";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 3)
            {
                cat = "Тяжелая атлетика";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
            else if (c1 == 4)
            {
                cat = "Гимнастический снаряд";
                string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t2.CategoryName LIKE '%" + cat + "%' AND t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Employee");
                    sda.Fill(dt);
                    sport.ItemsSource = dt.DefaultView;
                }
                int count_row = sport.Items.Count;
                zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
            }
        }

        private void zakaz_Click(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Show();
            this.Close();
        }


        //DataTable myTable = new DataTable();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sport.CanUserAddRows = false;
            sport.AutoGenerateColumns = true;
            sortirovka.Items.Add("По возрастанию");
            sortirovka.Items.Add("По убыванию");
            var category = Helper.db.Category.Select(x => x.CategoryName).ToList();	//Все категории
            category.Insert(0, "Все категории");		//Добавить первой «Все категории»
            sortirovka.SelectedIndex = 0;
            string connectionString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select CategoryName from Category", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            kategoria.Items.Insert(0, "Все категории");
            while (dr.Read())
            {
                //kategoria.Items.Insert(0, "Все категории");
                kategoria.Items.Add(dr["CategoryName"]);
            }
            conn.Close();
            //SqlConnection conn = new SqlConnection();
            //kategoria.Data = category;	//Занести построенный список
            //Начальные данные для фильтрации

            kategoria.SelectedIndex = 0;
            sort = "ASC";
            ShowInfo();
        }

        private void ShowInfo()
        {
            string group = "";
            int gr1 = sortirovka.SelectedIndex;
            if (gr1 == 0)
            {
                group = "ASC";
            }
            else if (gr1 == 1)
            {
                group = "DESC";
            }
            string text = poisk.Text;
            string ConString = @"Data Source=DESKTOP-U3T0DTQ\MSSQLSERVER01;Initial Catalog=OOOMuscle;User Id=sa;Password=qwerty";
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT t1.ArticleID, t1.Name, t2.CategoryName, t3.PostavshikName, t4.ProizvodilelName, t1.Cost FROM Product AS t1 INNER JOIN Category AS t2 ON t1.CategoryID = t2.CategoryID INNER JOIN Postavshik AS t3 ON t1.PostavshikID = t3.PostavshikID INNER JOIN Proizvoditel AS t4 ON t1.ProizvoditelID = t4.ProizvoditelID WHERE t1.Name LIKE '%" + text + "%' ORDER BY Name " + group;
                   // "AND Product.PostavshikID = Postavshik.PostavshikID AND Product.CategoryID = Category.CategoryID";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Employee");
                sda.Fill(dt);
                sport.ItemsSource = dt.DefaultView;
                con.Close();
            }
            int count_row = sport.Items.Count;
            zapisi.Content = "Количество записей: " + Convert.ToString(count_row);
        }
    }
}

