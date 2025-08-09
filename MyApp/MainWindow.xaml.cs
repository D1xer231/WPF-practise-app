using Microsoft.EntityFrameworkCore;
using MyApp.Models;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace MyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainScreen.IsChecked = true;

            AppDbContext db = new AppDbContext();
            List<Users> users = db.Users.ToList();

            UsersList.ItemsSource = users;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string objName = ((RadioButton)sender).Name;

            StackPanel[] panels = { MainScreenPanel, UserListScreenpanel, UserCabinetScreenPanel };
            foreach (var panel in panels)
                panel.Visibility = Visibility.Hidden; //Collapsed

            switch (objName)
            {
                case "MainScreen": MainScreenPanel.Visibility = Visibility.Visible; break;
                case "UserListScreen": UserListScreenpanel.Visibility = Visibility.Visible; break;
                case "UserCabinetScreen": UserCabinetScreenPanel.Visibility = Visibility.Visible; break;
            }

        }

        private async void ActivateCode_ClickAsync(object sender, RoutedEventArgs e)
        {
            //string code = EnterCodeField.Text.Trim();

            //if (string.IsNullOrEmpty(code))
            //{
            //    MessageBox.Show("Please enter a valid code.");
            //    return;
            //}

            //using (var db = new AppDbContext())
            //{
            //    try
            //    {
            //        bool isCodeValid = await db.Codes.AnyAsync(c => c.code == code);
            //        MessageBox.Show(isCodeValid
            //            ? "Code activated successfully"
            //            : "This code not exist.");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error: {ex.Message}");
            //    }
            //}
            switch (EnterCodeField.Text.Trim())
            {
                case "Meth-97VJW":
                    MessageBox.Show("Code activated successfully");
                    //string imageFile = "/img/walter.jpg";
                    //string fullPath = Path.Combine(Directory.GetCurrentDirectory(), imageFile);
                    //Process.Start(new ProcessStartInfo(fullPath) { UseShellExecute = true });
                    break;
                case "Meth-MBS4B":
                    MessageBox.Show("Code activated successfully.");
                    break;
                case "Meth-U3J59":
                    MessageBox.Show("Code activated successfully.");
                    break;
                case "Meth-V3PU4":
                    MessageBox.Show("Code activated successfully.");
                    break;
                case "Meth-PTM6B":
                    MessageBox.Show("Code activated successfully.");
                    break;
                default:
                    MessageBox.Show("Invalid code entered.");
                    break;
            }
            EnterCodeField.Clear();
        }
    }
}