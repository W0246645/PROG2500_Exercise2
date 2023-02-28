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

namespace Exercise2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Pages.Home homePage { get; set; }

        public Pages.Product productPage { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            homePage = new Pages.Home();
            productPage = new Pages.Product();
            mainFrame.NavigationService.Navigate(homePage);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(homePage);
        }

        private void ProductButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.Navigate(productPage);
        }
    }
}
