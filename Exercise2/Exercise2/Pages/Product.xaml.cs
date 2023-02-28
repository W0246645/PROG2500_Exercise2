using Exercise2.Data;
using Microsoft.EntityFrameworkCore;
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

namespace Exercise2.Pages
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        private readonly NorthwindContext _context = new NorthwindContext();
        private CollectionViewSource productViewSource;

        public Product()
        {
            InitializeComponent();
            productViewSource = (CollectionViewSource)FindResource(nameof(productViewSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _context.Products.Load();
            productViewSource.Source = _context.Products.Local.ToObservableCollection();
        }
    }
}
