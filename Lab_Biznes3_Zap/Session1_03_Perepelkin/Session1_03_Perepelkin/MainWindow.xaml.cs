using Session1_03_Perepelkin.Pages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Session1_03_Perepelkin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionString = @"data source=IRBIS-NB78;initial catalog=Session2_03_Perepelkin;integrated security=True";
        //static string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;initial catalog=Session2_03_Perepelkin;integrated security=True";

        SqlConnection cnn = new SqlConnection(connectionString);

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (!(e.Content is Page page)) return;
            this.Title = $"{page.Title}";

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
    }
}
