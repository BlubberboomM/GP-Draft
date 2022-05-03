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

namespace Test_GP_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MyWindow_Loaded;
        }

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new Page10());
        }

        private void toporkkebabdropdown(object sender, MouseButtonEventArgs e)
        {
            //this.NavigationService.Navigate(new Page10());
            // Uri uri = new Uri("Page10.xaml", UriKind.Relative); //Line 1
            //NavigationService ns = NavigationService.GetNavigationService(this); //Line 2
            //ns.NavigationService.Navigate(uri); //Line 3
            // this.NavigationService.Navigate(new Uri("Page10.xaml", UriKind.Relative));
            this.NavigationService.Navigate(new Page10());

        }
    }
}
