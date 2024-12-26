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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        public ProductsPage()
        {
            InitializeComponent();

            // Пример данных
            var products = new List<Product>
            {
                new Product { Name = "Корпус", ProductNumber = "113", Quantity = 250, ManufactureDate = "28.10.2024" }
            };

            DataContext = products;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public int Quantity { get; set; }
        public string ManufactureDate { get; set; }
    }
}