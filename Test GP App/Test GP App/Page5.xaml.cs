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
    /// Interaction logic for Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        string localtime;
        string nickName;
        string cardName;
        string phoneNum;
        double totalAmount;
        public Page5(string name, string phone, double total, string time)
        {
            InitializeComponent();

            totalText.Text = "Your Total: $" + total.ToString("0.00");
            localtime = time;
            nickName = name;
            phoneNum = phone;
            totalAmount = total;
            nameBox.Text = name;
        }

        private void back(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new Page4(localtime));
        }

        private void submit(object sender, MouseButtonEventArgs e)
        {
            cardName = nameBox.Text;
            ///this.NavigationService.Navigate(new Page6(nickName,cardName,phoneNum,totalAmount,localtime));
            ///Either get these variables through 6 to 9, or through MainWindow to 9.
        }
    }
}
