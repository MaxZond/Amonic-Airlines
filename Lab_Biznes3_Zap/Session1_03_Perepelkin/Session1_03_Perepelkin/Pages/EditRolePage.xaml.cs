using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
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
    /// Логика взаимодействия для EditRolePage.xaml
    /// </summary>
    public partial class EditRolePage : Page
    {
        private Users _currentUser = new Users();
        static string connectionString = @"data source=IRBIS-NB78;initial catalog=Session2_03_Perepelkin;integrated security=True";
        //static string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Session2_03_Perepelkin;integrated security=True";
        List<string> user = new List<string>();
        DataGrid dg_Users = new DataGrid();

        SqlConnection cnn = new SqlConnection(connectionString);
        public EditRolePage(string userEmail, DataGrid dg)
        {
            InitializeComponent();
            this.Title = "Edit user";

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

            DataContext = _currentUser;
            OfficeCB.ItemsSource = title;
            user.Add(userEmail);
            dg_Users = dg;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "Update Users Set User_Role = @ru, FirstName = @fn, LastName = @ln, Title = @tl Where Email = @em";
                cmd.Parameters.AddWithValue("@ru", (bool)UserRadio.IsChecked ? "User" : "Administrator");
                cmd.Parameters.AddWithValue("@fn", FirstNameTBox.Text);
                cmd.Parameters.AddWithValue("@ln", LastNameTBox.Text);
                cmd.Parameters.AddWithValue("@tl", Convert.ToString(OfficeCB.SelectedItem));
                cmd.Parameters.AddWithValue("@em", EmailTBox.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Chenched was saved!");
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt_User = new DataTable();

            SqlCommand sqlCommand = cnn.CreateCommand();
            sqlCommand.CommandText = "select FirstName, LastName, Title, User_Role from Users where Email = '" + user[0] + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dt_User);

            for (int i = 0; i < dt_User.Columns.Count; i++)
                user.Add(dt_User.Rows[0][i].ToString());

            for (int i = 0; i < user.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        EmailTBox.Text = user[i];
                        break;
                    case 1:
                        FirstNameTBox.Text = user[i];
                        break;
                    case 2:
                        LastNameTBox.Text = user[i];
                        break;
                    case 4:
                        if (user[4] == "User")
                            UserRadio.IsChecked = true;
                        else
                            AdminRadio.IsChecked = true;
                        break;
                }
            }

            for (int i = 0; i < OfficeCB.Items.Count; i++)
                if (OfficeCB.Items[i].ToString() == user[3])
                    OfficeCB.SelectedIndex = i;
        }
    }
}
