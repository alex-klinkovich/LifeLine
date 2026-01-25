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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LifeLine
{
    /// <summary>
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();

        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // sql injection proof, check if remember me is on or not and implement tokens, 2 factor verification later

           


        }
        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Forgot password clicked");
        }

        private void Register_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisterRoleSelectionPage());
        }
    }
}
