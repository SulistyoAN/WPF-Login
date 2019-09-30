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
using WPF_Login.Controller;

namespace WPF_Login.View
{
    /// <summary>
    /// Interaction logic for Update_Page.xaml
    /// </summary>
    public partial class Update_Page : Window
    {
        public string GUsername;

        public Update_Page(string username)
        {
            InitializeComponent();
            UnameSetter(username);
            Username.Text = username;
        }
        public void UnameSetter(string Uname)
        {
            GUsername = Uname;
        }

        private void Renew_Click(object sender, RoutedEventArgs e)
        {
            User_Controller Controller = new User_Controller();

            if (Username.Text.Length == 0 && Password.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "You are Enter Valid Username!";
                PasswordErrorMessage.Text = "You are Enter Password";
            }
            else if (Username.Text.Length == 0)
            {
                UsernameErrorMessage.Text = "Enter the valid username";
                Username.Focus();
            }
            else if (Password.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "You must enter password";
                Password.Focus();
            }
            else
            {
                string username = Username.Text;
                string password = Password.Password;

                Controller.ChangePass(username, password);
                this.Hide();
                Home home = new Home(GUsername);
                home.Show();
            }
        }
    }
}
