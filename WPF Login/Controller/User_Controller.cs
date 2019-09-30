using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Login.Context;
using WPF_Login.Models;

namespace WPF_Login.Controller
{
    class User_Controller
    {
        public void addUser(string username, string password)
        {   
            var result = 0;
            User user = new User();
            MyContext _context = new MyContext();

            user.Username = username;
            user.Password = password;
            _context.Users.Add(user);
            result = _context.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Register Succesful!");
            }
                MessageBox.Show("Register failed!");
        }

        public bool UserLogin(string username, string password)
        {
            var status = true;

            User user = new User();
            MyContext _context = new MyContext();

            var get = _context.Users.Where(u => u.Username == username).FirstOrDefault<User>();

            if (get == null)
            {
                MessageBox.Show("You aren not registered");
                status = false;
            }
            else
            {
                if (get.Password != password)
                {
                    MessageBox.Show("Your Password is incorrect!");
                    status = false;
                }
                else
                {
                    MessageBox.Show("Login Succesfull");
                }
            }
            return status;
        }

    public void ChangePass(string username, string password)
    {
        var result = 0;

        User user = new User();
        MyContext _context = new MyContext();


        var get = _context.Users.Where(u => u.Username == username).FirstOrDefault<User>();

        if (get == null)
            {
                MessageBox.Show("Your Username is Incorect");
            }
        else
            {
                if (get.Password != password)
                {
                    get.Password = password;
                    result = _context.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Update Succes!");
                    }
                    else
                    {
                        MessageBox.Show("Update Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Your Password Can't be the same");
                }

            }
       }
     }
}
