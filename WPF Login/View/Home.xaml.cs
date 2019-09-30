using System;
using System.Collections.Generic;
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
namespace WPF_Login.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public string GUsername;
        public Home(string uname)
        {
            InitializeComponent();
            UnameSetter(uname);
            WelcomeMessage.Text = "Welcome, " + uname + "!";
        }

        public void UnameSetter(string uname)
        {
            GUsername = uname;
        }

        private void Update_Data_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Update_Page up = new Update_Page(GUsername); 
            up.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Logout Successfull");
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
