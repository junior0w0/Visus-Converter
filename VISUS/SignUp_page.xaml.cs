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
    /// Interaction logic for SignUp_page.xaml
    /// </summary>
    public partial class SignUp_page : Page
    {
        public SignUp_page()
        {
            InitializeComponent();
        }

        private void BtnClickLogin(object sender, RoutedEventArgs e)
        {
            Main.Content = new Login_Page();
        }

        private void BtnClickSingUp(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
