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
        private enum LoginState
        {
            Login,
            ContinueRegister
        }
        private LoginState loginState = LoginState.Login;


        public LogInPage()
        {
            InitializeComponent();
        }




        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (loginState == LoginState.Login)
                NavigationService.Navigate(new HomePage());
            else
            {
                ShowLoginForm();
                loginState = LoginState.Login;
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // sql injection proof, check if remember me is on or not and implement tokens, 2 factor verification later
            if(loginState == LoginState.Login)
            {
                // regular login flow
            }
            else
            {
                // redirection to the place a user picked off
            }
           


        }
        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Forgot password clicked");
        }

        private void Register_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage(-1, 1)); // roleId(unknown yet therefore -1) first step
        }

        private void ContinueRegistration_Click(object sender, MouseButtonEventArgs e)
        { 
            ShowContinueRegisterForm();
            loginState = LoginState.ContinueRegister;
        }
        private void ShowLoginForm()
        {
            PageTitle.Text = "Universal Login";
            UnderPageTitle.Text = "Secure access for everyone";

            RegisterContinueStackPanel.Visibility = Visibility.Visible;
            LoginButton.Content = "Login";
        }
        private void ShowContinueRegisterForm()
        {
            PageTitle.Text = "Registration Continuation";
            UnderPageTitle.Text = "Continue where you picked off";

            RegisterContinueStackPanel.Visibility = Visibility.Collapsed;
            LoginButton.Content = "Continue";
        }
    }
}
