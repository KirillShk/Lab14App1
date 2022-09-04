using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab14App1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Картошка",
                PriceProduct = 100,
                ImageProduct = "Data/potateto.png",
                CategoryProduct = Categorys.Food
                
            });
            products.Add(new Product()
            {
                NameProduct = "Марковь",
                PriceProduct = 50,
                ImageProduct = "Data/сarrot.png",
                CategoryProduct = Categorys.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Холодильник",
                PriceProduct = 15000,
                ImageProduct= "Data/refigerator.png",
                CategoryProduct = Categorys.Technic
            });
            products.Add(new Product()
            {
                NameProduct = "Телевизор",
                PriceProduct = 7000,
                ImageProduct = "Data/tv.png",
                CategoryProduct = Categorys.Technic
            });
            lstBox.ItemsSource = products;
        }
    }
}
