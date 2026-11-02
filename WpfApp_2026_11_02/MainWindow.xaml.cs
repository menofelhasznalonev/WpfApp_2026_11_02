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

namespace WpfApp_2026_11_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new HomePage());
        }
        
        private void HomeClick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HomePage());
        }

        private void ProfileClick(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ProfilePage());
        }

        private void OpenWindowClick(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Owner = this;
            infoWindow.Show();
        }

        private void OpenDialogClick(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Owner = this;
            infoWindow.ShowDialog();
        }
    }
}