using System;
using System.Collections.Generic;
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

namespace Test_GP_App
{
    /// <summary>
    /// Interaction logic for Page6.xaml
    /// </summary>
    public partial class Page6 : Page
    {
        public Page6()
        {
            InitializeComponent();
        }

        private void CloseAppButtonClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void ReturnToMenuButtonClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }

        private void ReturnToMenuTextClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }

        private void CloseAppTextClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
