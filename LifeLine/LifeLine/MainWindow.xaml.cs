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
using LifeLine.LifeLineServiceReference;

namespace LifeLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        //Example for using server in client

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(NumberBox.Text.ToString());
            LifeLineServiceReference.Service1Client srv = new LifeLineServiceReference.Service1Client();
            int res = srv.Sub(num);
            labelRes.Content = res.ToString();
        }
        
    }
}
