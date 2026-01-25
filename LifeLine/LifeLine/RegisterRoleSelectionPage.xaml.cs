using LifeLine.LifeLineServiceReference;
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
    /// Interaction logic for RegisterRoleSelectionPage.xaml
    /// </summary>
    public partial class RegisterRoleSelectionPage : Page
    {
        private readonly int[] roleIds = { 1, 2, 3 };
        
        public RegisterRoleSelectionPage()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();

        }
        private void Responder_Click(object sender, RoutedEventArgs e)
        {
            // pass to register page with an indicator for the role
            NavigationService.Navigate(new RegisterPage(roleIds[0]));
            
        }
        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage(roleIds[1]));
        }
        private void Civilian_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage(roleIds[2]));
        }

    }
}
