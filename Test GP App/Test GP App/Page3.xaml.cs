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
using System.Globalization;


namespace Test_GP_App
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();

            setText();
        }

        public void setText()
        {
            /// Grabs current time, adds five minutes and plonks it onto the first button

            DateTime localTime = DateTime.Now;
            localTime = localTime.AddMinutes(5);
            asapText.Text = "Pick up ASAP:\n" + localTime.ToString("h:mm tt");
        }
    }
}
