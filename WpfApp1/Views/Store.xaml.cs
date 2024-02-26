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
using System.Windows.Shapes;
using WpfApp1.Entitys;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для Store.xaml
    /// </summary>
    public partial class Store : Window
    {
        public Store()
        {
            InitializeComponent();
        }

        private void add_in_Shopping_cart_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = ListViewProducts.SelectedItem as Product;

            if (selectedProduct != null)
            {
                Shopping_cart secondWindow = new Shopping_cart();

                secondWindow.AddProductToListView(selectedProduct);
            }
        }

        private void go_to_shopping_cart_Click(object sender, RoutedEventArgs e)
        {
            Shopping_cart win = new Shopping_cart();
            win.Show();
            this.Close();
        }
    }
}
