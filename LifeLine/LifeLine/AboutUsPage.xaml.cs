using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Diagnostics;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace LifeLine
{
    /// <summary>
    /// Interaction logic for AboutUsPage.xaml
    /// </summary>
    public partial class AboutUsPage : Page
    {
        public AboutUsPage()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void GitHubLink_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/alex-klinkovich",
                UseShellExecute = true
            });
        }
    }
}
