using System;
using System.IO;
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
    /// Interaction logic for Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();
        }

        private void LogoutButtonClick(object sender, MouseButtonEventArgs e)
        {
            string name = File.ReadAllText("Names.txt");
            Order1.Text = "" + name;
            this.NavigationService.Navigate(new Page1());
        }

        private void LogoutTextClick(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
