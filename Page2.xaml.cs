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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ReviewOrderTextClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void ReviewOrderButtonClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void toporkkebabdropdown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page10());
        }

        private void tochickenkebabdropdown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page11());
        }

        private void tosweetfrydropdown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page12());
        }

        private void tofrydropdown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page13());
        }

        private void toporkribdropdown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page14());
        }

        private void toonionringdropdown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page15());
        }
    }
}
