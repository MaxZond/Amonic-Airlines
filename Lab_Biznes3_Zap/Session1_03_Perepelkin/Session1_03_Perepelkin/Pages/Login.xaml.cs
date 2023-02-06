using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Session1_03_Perepelkin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        static string connectionString = @"data source=IRBIS-NB78;initial catalog=Session2_03_Perepelkin;integrated security=True";
        //static string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Session2_03_Perepelkin;integrated security=True";

        SqlConnection cnn = new SqlConnection(connectionString);
        public Login()
        {
            InitializeComponent();

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "SELECT Remember, Email, Password FROM LastLogin WHERE Id = 1";
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read()) { 
                if ((bool)r.GetValue(0) == true) { 
                    Remember_me.IsChecked = true; 
                    UsernameTB.Text = r.GetValue(1).ToString(); 
                    PasswordBox.Password = r.GetValue(2).ToString(); 
                } 
            }
            cnn.Close();
        }

        List<string> userLastName = new List<string>();
        List<string> userLogin = new List<string>();
        List<string> userName = new List<string>();
        List<string> userPassword = new List<string>();
        List<bool> userActivity = new List<bool>();
        List<string> userRole = new List<string>();

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool remember = false;
            try
            {
                if (Remember_me.IsChecked == true)
                    remember = true;

                if ((bool)Remember_me.IsChecked == false)
                    remember = false;

                userLogin = AppData.db.Users.Where(a => a.Email == UsernameTB.Text).Select(b => b.Email).ToList();
                userName = AppData.db.Users.Where(a => a.Email == UsernameTB.Text).Select(b => b.FirstName).ToList();
                userLastName = AppData.db.Users.Where(a => a.Email == UsernameTB.Text).Select(b => b.LastName).ToList();
                userPassword = AppData.db.Users.Where(a => a.Password == PasswordBox.Password).Select(b => b.Password).ToList();
                userActivity = AppData.db.Users.Where(a => a.Email == UsernameTB.Text).Select(b => b.Active).ToList();
                userRole = AppData.db.Users.Where(a => a.Email == UsernameTB.Text).Select(b => b.User_Role).ToList();

                if (userActivity[0] == false)
                {
                    MessageBox.Show("Данный профиль был заблокирован администратором!", "Ошибка");
                    return;
                }


                if (remember == true)
                {
                    cnn.Open();
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = "Update LastLogin Set Email = @em, Password = @pu, Remember = @rem Where Id = @ru";
                    cmd.Parameters.AddWithValue("@ru", 1);
                    cmd.Parameters.AddWithValue("@em", UsernameTB.Text);
                    cmd.Parameters.AddWithValue("@pu", PasswordBox.Password);
                    cmd.Parameters.AddWithValue("@rem", remember);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                else
                {
                    cnn.Open();
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = "Update LastLogin Set Remember = @rem Where Id = @ru";
                    cmd.Parameters.AddWithValue("@ru", 1);
                    cmd.Parameters.AddWithValue("@rem", remember);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }


                if (UsernameTB.Text == userLogin[0] && PasswordBox.Password == userPassword[0])
                {
                    MessageBox.Show($"Welcome {Convert.ToString(userName[0])}!");
                    if (userRole[0] == "Administrator") NavigationService?.Navigate(new AdminPage(userLogin[0]));
                    if (userRole[0] == "User") NavigationService?.Navigate(new UserPage(UsernameTB.Text));
                }
            }
            catch
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка!");
            }
        }
    }
}


//            private static Session2_03_PerepelkinEntities _context = new Session2_03_PerepelkinEntities();

//public static Session2_03_PerepelkinEntities GetContext()
//{
//    if (_context == null)
//        _context = new Session2_03_PerepelkinEntities();

//    return _context;
//}






//public int Age
//{
//    get
//    {
//        var age = DateTime.Now.Year - Birthdate.Year;
//        if (DateTime.Now.DayOfYear < Birthdate.DayOfYear) age--;
//        return age;
//    }
//}
