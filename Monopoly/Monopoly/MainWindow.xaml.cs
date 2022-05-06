using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Monopoly
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       private static NavigationService ns;

        public MainWindow()
        {

           
             
           
            ns = NavigationService.GetNavigationService(this);

        }
        public static void FrameChanger(string val)
        {

            ns.Navigate(new Uri(val, UriKind.Relative));

            //   Main.Source = new Uri("Menu.xaml",UriKind.Relative);
            // Main.NavigationService.Navigate(typeof(Game));
            // navigationService.Navigate(g);
            //MessageBox.Show("Hello, world!");



        }
    }
}
