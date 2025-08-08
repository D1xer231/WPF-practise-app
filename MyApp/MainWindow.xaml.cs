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
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string objName = ((RadioButton)sender).Name;

            StackPanel[] panels = { MainScreenPanel }; // UserListScreenpanel };
            foreach (var panel in panels)
                panel.Visibility = Visibility.Hidden; //Collapsed

            switch (objName)
            {
                case "MainScreen": MainScreenPanel.Visibility = Visibility.Visible; break;
                //case "UserListScreen": UserListScreenpanel.Visibility = Visibility.Visible; break;
            }

        }
    }
}