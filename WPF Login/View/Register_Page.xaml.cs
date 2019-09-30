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
    /// Interaction logic for Ragister_Page.xaml
    /// </summary>
    public partial class Register_Page : Window
    {
        public Register_Page()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            User_Controller Controller = new User_Controller();

            if (Username.Text.Length == 0 && Password.Password.Length == 0 && VerifyPassword.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "Enter the valid username";
                PasswordErrorMessage.Text = "You must enter password";
                VerifyPasswordErrorMessage.Text = "You must enter verify password";
                Username.Focus();
                Password.Focus();
                VerifyPassword.Focus();
            }
            else if (Username.Text.Length == 0 && Password.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "Enter the valid username";
                PasswordErrorMessage.Text = "You must enter password";
                Username.Focus();
                Password.Focus();
            }
            else if (Username.Text.Length == 0 && VerifyPassword.Password.Length == 0)
            {
                UsernameErrorMessage.Text = "Enter the valid username";
                VerifyPasswordErrorMessage.Text = "You must enter password";
                Username.Focus();
                VerifyPassword.Focus();
            }
            else if (Password.Password.Length == 0 && VerifyPassword.Password.Length == 0)
            {
                PasswordErrorMessage.Text = "Enter the valid username";
                VerifyPasswordErrorMessage.Text = "You must enter password";
                Password.Focus();
                VerifyPassword.Focus();
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
            else if (VerifyPassword.Password.Length == 0)
            {
                VerifyPasswordErrorMessage.Text = "You must enter verify password";
            }
            else if (Password.Password.Length != VerifyPassword.Password.Length)
            {
                VerifyPasswordErrorMessage.Text = "Verify password must be same with Password";
                VerifyPassword.Focus();
            }
            else
            {
                string username = Username.Text;
                string password = Password.Password;

                Controller.addUser(username, password);
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }
        }
    }
}

