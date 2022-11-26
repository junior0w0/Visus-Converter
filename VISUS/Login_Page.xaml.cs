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

namespace UTS_Kelompok3
{
    /// <summary>
    /// Interaction logic for Login_Page.xaml
    /// </summary>
    public partial class Login_Page : Page
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void BtnClickCreate(object sender, RoutedEventArgs e)
        {
            Main.Content = new SignUp_page();
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
