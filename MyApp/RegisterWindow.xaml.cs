using MyApp.Models;
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
using System.Security.Cryptography;

namespace MyApp
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        private AppDbContext _db;

        public RegisterWindow()
        {
            InitializeComponent();
            _db = new AppDbContext();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = UsernameField.Text.Trim();
            string email = EmailField.Text.Trim();
            string password = PasswordField.Password.Trim();
            string favMeth = FavMethField.Text.Trim();
            if (name.Equals("") || !email.Contains("@") || password.Length < 4 || favMeth.Equals(""))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            Users AuthUser = _db.Users.Where(el => el.email == email).FirstOrDefault();
            if (AuthUser != null)
            {
                MessageBox.Show("User with this email already exists.");
                return;
            }

            Users user = new Users(name, email, Hash(password), favMeth);
            _db.Users.Add(user);
            _db.SaveChanges();

            UsernameField.Text = "";
            EmailField.Text = "";
            PasswordField.Password = "";
            FavMethField.Text = "";
            RegisterButton.Content = "Registered!";
            MessageBox.Show("Registration successful!");
        }

        private string Hash(string input)
        {
            byte[] temp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(temp);
                return Convert.ToBase64String(hash);
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            //AuthWindow window = new AuthWindow();
            //window.Show();
            Close();
        }
    }
}
