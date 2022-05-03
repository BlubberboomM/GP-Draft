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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        static DateTime localTime = (DateTime.Now).AddMinutes(5);
        int hour = localTime.Hour;
        int min = localTime.Minute;
        public Page3()
        {
            InitializeComponent();

            setText();
        }

        public void setText()
        {
            /// Grabs current time, adds five minutes and plonks it onto the first button

            asapText.Text = "Pick up ASAP:\n" + localTime.ToString("h:mm tt");
            pickUpText.Text = "Pick up at:       " + hour.ToString("00") + ":" + min.ToString("00");
        }

        private void asap_Click(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(localTime.ToString("h:mm tt")));
        }

        private void pickup_Click(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(hour.ToString("00") + ":" + min.ToString("00")));
        }

        private void minUp(object sender, RoutedEventArgs e)
        {
            if (min == 59)
            {
                min = 0;
            }
            else
            {
                min = min + 1;
            }
            setText();
        }

        private void minDn(object sender, RoutedEventArgs e)
        {
            if (min == 0)
            {
                min = 59;
            }
            else
            {
                min = min - 1;
            }
            setText();
        }

        private void tenUp(object sender, RoutedEventArgs e)
        {
            if (min > 49)
            {
                min = min - 50;
            }
            else
            {
                min = min + 10;
            }
            setText();
        }

        private void tenDn(object sender, RoutedEventArgs e)
        {
            if (min < 10)
            {
                min = min + 50;
            }
            else
            {
                min = min - 10;
            }
            setText();
        }

        private void hourUp(object sender, RoutedEventArgs e)
        {
            if (hour == 24)
            {
                hour = 1;
            }
            else
            {
                hour = hour + 1;
            }
            setText();
        }

        private void hourDn(object sender, RoutedEventArgs e)
        {
            if (hour == 1)
            {
                hour = 24;
            }
            else
            {
                hour = hour - 1;
            }
            setText();
        }

        private void back(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }
    }
}
