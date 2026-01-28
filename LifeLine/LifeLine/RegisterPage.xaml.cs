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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private readonly int _roleId;
        private static Dictionary<int, string> rolesDict = null; // singleton pattern design

        SolidColorBrush colorBrush = new SolidColorBrush();

        private int _currentStep;  // get it from previous page
        public RegisterPage(int roleId, int currentStep) // instead - int currentStep
        {
            InitializeComponent(); 

            if (rolesDict == null)
            {
                rolesDict = new Dictionary<int, string>();
                FillRoleDictionary();
            }// singleton pattern desing important to remember
            _currentStep = currentStep;    

            if(_currentStep == 4)
            {
                // show according grid.
            }

            
        }
        private void FillRoleDictionary()
        {
            rolesDict.Add(1, "Respnder");
            rolesDict.Add(2, "Doctor");
            rolesDict.Add(3, "Civilian");
        }
        
        private void ShowThirdStep()
        {
            UserInfoGrid.Visibility = Visibility.Collapsed;
            PersonalInfoGrid.Visibility = Visibility.Visible;

            StepLabel.Text = "Step 3 of 3 — Personal Info";
        }
        private void ShowSecondStep()
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            /*
             
            if (currentStep == 2)
            {
                
                // UserInfoGrid.Visibility = Visibility.Collapsed;
                // PersonalInfoGrid.Visibility = Visibility.Visible;
                
                StepLabel.Text = "Step 3 of 3 — Personal Info";
                currentStep = 3;

                colorBrush.Color = Color.FromRgb(139, 92, 243); // purple dot
                ThirdProgressPoint.Fill = colorBrush;
            }
            else
            {
                // TODO: submit form to backend
                MessageBox.Show("Register completed!");
            }
            */
            switch(_currentStep)
            {
                case 1:

                    // save in db the data

                    UserInfoGrid.Visibility = Visibility.Collapsed;
                    PersonalInfoGrid.Visibility = Visibility.Visible;

                    StepLabel.Text = "Step 2 of 4 — Personal Info";

                    colorBrush.Color = Color.FromRgb(139, 92, 246); // purple - "filled"
                    SecondProgressPoint.Fill = colorBrush;

                    _currentStep = 2;

                    break;

                case 2:

                    // save in db the data
                    NavigationService.Navigate(new RegisterRoleSelectionPage());
                    // it should navigate to the roleSelectionPage
                    //      -> user presses back: return registerPage(2, roleId)
                    //      -> user presses on one of the roles: return registerPage(4, roleId)

                    break;

                case 4:
                    
                    // save in db the data
                    // register complete!
                    // navigate to the login page
                   
                    break;
                    
            }
            
    
                
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            /*
            if (_currentStep == 3)
            {
                UserInfoGrid.Visibility = Visibility.Visible;
                PersonalInfoGrid.Visibility = Visibility.Collapsed;

                StepLabel.Text = "Step 2 of 3 — User Info";
                _currentStep = 2;

                colorBrush.Color = Color.FromRgb(71, 85, 105); // dark blue - "not filled"
                ThirdProgressPoint.Fill = colorBrush;
            }
            else
            {
                // go back to role selection
                NavigationService.GoBack();
            }
            */
            switch (_currentStep)
            {
                case 1:

                    NavigationService.Navigate(new LogInPage());

                    break;

                case 2:

                    UserInfoGrid.Visibility = Visibility.Visible;
                    PersonalInfoGrid.Visibility = Visibility.Collapsed;

                    StepLabel.Text = "Step 1 of 4 — User Info";
                    _currentStep = 1;

                    colorBrush.Color = Color.FromRgb(71, 85, 105); // dark blue - "not filled"
                    SecondProgressPoint.Fill = colorBrush;

                    break;

                case 4:

                    NavigationService.Navigate(new RegisterRoleSelectionPage());

                    break;
            }
        }
        // visual functions
        private void TogglePassword_Checked(object sender, RoutedEventArgs e)
        {
            PasswordText.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Collapsed;
            PasswordText.Visibility = Visibility.Visible;
        }

        private void TogglePassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = PasswordText.Text;
            PasswordText.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Visible;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (TogglePassword.IsChecked == true)
                PasswordText.Text = PasswordBox.Password;
        }

        private void PasswordText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TogglePassword.IsChecked == true)
                PasswordBox.Password = PasswordText.Text;
        }

        // ---- Same for confirm password ----
        private void ToggleConfirm_Checked(object sender, RoutedEventArgs e)
        {
            ConfirmPasswordText.Text = ConfirmPasswordBox.Password;
            ConfirmPasswordBox.Visibility = Visibility.Collapsed;
            ConfirmPasswordText.Visibility = Visibility.Visible;
        }

        private void ToggleConfirm_Unchecked(object sender, RoutedEventArgs e)
        {
            ConfirmPasswordBox.Password = ConfirmPasswordText.Text;
            ConfirmPasswordText.Visibility = Visibility.Collapsed;
            ConfirmPasswordBox.Visibility = Visibility.Visible;
        }

        private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (ToggleConfirm.IsChecked == true)
                ConfirmPasswordText.Text = ConfirmPasswordBox.Password;
        }

        private void ConfirmPasswordText_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ToggleConfirm.IsChecked == true)
                ConfirmPasswordBox.Password = ConfirmPasswordText.Text;
        }

    }
}
