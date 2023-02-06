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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Session1_03_Perepelkin.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        private Users _currentUser = new Users();
        static string connectionString = @"data source=IRBIS-NB78;initial catalog=Session2_03_Perepelkin;integrated security=True";
        //static string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Session2_03_Perepelkin;integrated security=True";

        SqlConnection cnn = new SqlConnection(connectionString);
        public AddUserPage()
        {
            InitializeComponent();
            this.Title = "Add user";
            List<string> title = new List<string>();

            cnn.Open();
            DataContext = _currentUser;
            SqlCommand t1 = cnn.CreateCommand();
            t1.CommandText = $@"select distinct(Title) from Users";
            SqlDataReader t2 = t1.ExecuteReader();
            while (t2.Read())
            {
                title.Add(t2.GetValue(0).ToString());
            }
            t2.Close();
            cnn.Close();

            BirthDate.Text = DateTime.Today.ToString();
            OfficeCB.ItemsSource = title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder err = new StringBuilder();
            DateTime date = (DateTime)BirthDate.SelectedDate;
                var age = DateTime.Now.Year - date.Year;
                if (DateTime.Now.DayOfYear < date.DayOfYear) age--;
            
            try
            {
                if (age > 16)
                {
                    cnn.Open();
                    SqlCommand cmd = cnn.CreateCommand();
                    cmd.CommandText = "Insert into Users (User_Role,Email,Password,FirstName,LastName,Title,Birthdate,Active)values(@ru,@em,@pu,@fn,@ln,@tl,@bd,@av)";
                    cmd.Parameters.AddWithValue("@ru", "User");
                    cmd.Parameters.AddWithValue("@em", EmailTBox.Text);
                    cmd.Parameters.AddWithValue("@pu", PasswordBox.Password);
                    cmd.Parameters.AddWithValue("@fn", FirstNameTBox.Text);
                    cmd.Parameters.AddWithValue("@ln", LastNameTBox.Text);
                    cmd.Parameters.AddWithValue("@tl", Convert.ToString(OfficeCB.SelectedItem));
                    cmd.Parameters.AddWithValue("@bd", (DateTime)BirthDate.SelectedDate);
                    cmd.Parameters.AddWithValue("@av", true);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Information was saved!");
                    NavigationService.GoBack();
                }
                else { MessageBox.Show("User too young for this job!"); return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
