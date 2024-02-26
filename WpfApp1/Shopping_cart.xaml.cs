using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Shopping_cart.xaml
    /// </summary>
    public partial class Shopping_cart : Window
    {
        public static List<Product> ProductList = new List<Product>();

        public Shopping_cart()
        {
            InitializeComponent();

            foreach (var product in ProductList)
            {
                ListViewProducts2.Items.Add(product);
            }

            decimal totalSum = 0;
            foreach (var item in ListViewProducts2.Items)
            {
                // Предположим, что у вас есть класс Product с полем Price, хранящим цену товара
                if (item is Product product)
                {
                    totalSum += product.Price;

                    cost.Text = Convert.ToString(totalSum);
                }
            }
        }

        public void AddProductToListView(Product product)
        {
            ListViewProducts2.Items.Add(product);

            ProductList.Add(product);
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            /*
            Button button = sender as Button;
            if (button != null)
            {
                Product selectedProduct = (Product)myListView.SelectedItem;
                if (selectedProduct != null)
                {
                    // Увеличение количества товара
                    selectedProduct.Quantity++;

                    // Обновление ListView
                    ICollectionView view = CollectionViewSource.GetDefaultView(myListView.ItemsSource);
                    view.Refresh();
                }
            }
            */
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            var win = new Store();
            win.Show();
            this.Close();
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы успешно оформили заказ, ожжидайте доставку послезавтра");
        }
    }
}
