using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Loading
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_user.Clear();
        }

        private void txt_pass_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_pass.Clear();
        }

        private void btn_prcd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            obj.Show();
            this.Close();
        }

        private void txt_user_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
