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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4(string time)
        {
            InitializeComponent();

            string localTime = time;
            pickupText.Text = "Pickup Time:\n" + localTime;
 
        }

        public void setText()
        {
            /// Retrieves a time from page 3

        }

        private void back(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }
    }
}
