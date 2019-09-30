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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Login.View;
using WPF_Login.Controller;

namespace WPF_Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            UserName.Text = Properties.Settings.Default.Username;
        }
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var p = new Register_Page();
            p.Show(); 
        }

        private void RememberCheck_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Username = UserName.Text;
            Properties.Settings.Default.Save();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            User_Controller Controller = new User_Controller();

            if (UserName.Text.Length == 0 && Password.Password.Length ==0)
            {
                UserNameErrorMessage.Text = "You must enter valid username";
                PasswordErrorMessage.Text = "You must enter password";
                UserName.Focus();
                Password.Focus();
            }
            else if (UserName.Text.Length == 0)
            {
                UserNameErrorMessage.Text = "You must enter valid username";
                UserName.Focus();
            }
            else if (Password.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "You must enter password";
                Password.Focus();
            }
            else
            {
                string username = UserName.Text;
                string password = Password.Password;

                var status = Controller.UserLogin(username, password);
                if (status == true)
                {
                    this.Hide();
                    Home home = new Home(username);
                    home.Show();
                }
            }
        }
    }
}
