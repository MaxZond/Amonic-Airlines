using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Session1_03_Perepelkin.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        static string connectionString = @"data source=IRBIS-NB78;initial catalog=Session2_03_Perepelkin;integrated security=True";
        //static string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Session2_03_Perepelkin;integrated security=True";
        SqlConnection cnn = new SqlConnection(connectionString);
        bool refreshDG = false;
        string emailAdmin = "";

        public AdminPage(string email)
        {
            InitializeComponent();
            this.Title = "AMONIC Airlines Automation System";
            emailAdmin = email;

            //var allOffice = Session2_03_PerepelkinEntities.GetContext().Users.ToList();
            //allOffice.Insert(0, new Users
            //{
            //    Title = "All Office"
            //});

            //OfficeComboBox.ItemsSource = allOffice;

            //ActiveCheckBox.IsChecked = false;
            //OfficeComboBox.SelectedIndex = 0;

            //var currentUser = Session2_03_PerepelkinEntities.GetContext().Users.ToList();
            //UserGrid.ItemsSource = currentUser;

            //UpdateUsers();
        }


        private void UpdateUsers()
        {
            List<Session1_03_Perepelkin.Users> currentUser = new List<Session1_03_Perepelkin.Users>();

            var currentOffice = OfficeComboBox.SelectedItem as Users;

            if (OfficeComboBox.SelectedIndex > 0)
                currentUser = AppData.db.Users.Where(p => p.Title == (OfficeComboBox.SelectedItem.ToString())).ToList();

            UserGrid.ItemsSource = currentUser;

            //UserGrid.ItemsSource = null;
              
            if (OfficeComboBox.SelectedIndex == 0)
            {
                UserGrid.ItemsSource = FindAllUsersInfo().AsDataView();
            }
            //else
            //{
            //    UserGrid.ItemsSource = FindByOfficesUsersInfo(OfficeComboBox.SelectedItem.ToString()).AsDataView();
            //}
        }

        private void OfficeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUsers();
        }

        private void AddUserButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Login());
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUserPage());
        }

        private void ChangeRoleButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserGrid.SelectedItems.Count == 1)
            {
                string userEmail = ((DataRowView)UserGrid.SelectedItems[0]).Row["Email"].ToString();
                refreshDG = true;
                NavigationService.Navigate(new EditRolePage(userEmail, UserGrid));
            }
            else
                MessageBox.Show("Select 1 person!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EnDisEnButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                TextBlock email = UserGrid.Columns[EmailColumn.DisplayIndex].GetCellContent(UserGrid.Items[UserGrid.SelectedIndex]) as TextBlock;
                if(email.Text == emailAdmin)
                {
                    MessageBox.Show("You can't disenable yourself!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandText = "Update Users Set Active = case when Active = 0 then 1 else 0 end Where Email = @em";
                cmd.Parameters.AddWithValue("@em", email.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Choose user!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Session2_03_PerepelkinEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            UserGrid.ItemsSource = Session2_03_PerepelkinEntities.GetContext().Users.ToList();

            UpdateUsers();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Session2_03_PerepelkinEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            UserGrid.ItemsSource = Session2_03_PerepelkinEntities.GetContext().Users.ToList();
            UpdateUsers();
        }

        private void UserGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
           
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            OfficeComboBox.ItemsSource = FillingCb("All Offices");
            OfficeComboBox.SelectedIndex = 0;
        }

        private void UserGrid_GotFocus(object sender, RoutedEventArgs e)
        {
            if (refreshDG)
            {
                refreshDG = false;
                UpdateUsers();
            }
        }

        public DataTable FindAllUsersInfo()
        {
            DataTable dt_Users = new DataTable();

            SqlCommand sqlCommand = cnn.CreateCommand();
            sqlCommand.CommandText = "select FirstName, LastName, datediff(year, Birthdate, getdate()) as Age, User_Role, Email, Title, case when Active = 0 then 'red' when User_Role = 'Administrator' then 'green' else 'white' end as User_Color from Users";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dt_Users);

            return dt_Users;
        }

        public DataTable FindByOfficesUsersInfo(string office)
        {
            DataTable dt_Users = new DataTable();

            SqlCommand sqlCommand = cnn.CreateCommand();
            sqlCommand.CommandText = "select FirstName, LastName, datediff(year, Birthdate, getdate()) as Age, User_Role, Email, Title, case when Active = 0 then 'red' when User_Role = 'Administrator' then 'green' else 'white' end as User_Color from Users where Title = '" + office + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dt_Users);

            return dt_Users;
        }

        public List<string> FillingCb(string FirstItem)
        {
            DataTable dt_Offices = new DataTable();
            List<string> offices = new List<string>() { FirstItem };

            SqlCommand sqlCommand = cnn.CreateCommand();
            sqlCommand.CommandText = "select distinct Title from Users";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dt_Offices);

            for (int i = 0; i < dt_Offices.Rows.Count; i++)
                offices.Add(dt_Offices.Rows[i][0].ToString());

            return offices;
        }
    }
}
