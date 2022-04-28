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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        string localtime;
        public Page4(string time)
        {
            InitializeComponent();

            

            localtime = time;
            pickupText.Text = "Pickup Time:\n" + localtime;

        }

        private void back(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

        private void pay_Now(object sender, MouseButtonEventArgs e)
        {
            string name = nameBox.Text;
            File.WriteAllText("Names.txt", name);
            string phone = phoneBox.Text;
            File.WriteAllText("Phones.txt", phone);
            double total = 20.00;
            this.NavigationService.Navigate(new Page5(name, phone, total, localtime));
        }

        private void pay_Pickup(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page6(localtime));
        }
    }
}