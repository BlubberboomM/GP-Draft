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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void PlaceOrderClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void EmployeeClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page9());
        }

        private void TextNextPageClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }
    }
}
