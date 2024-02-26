using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Entitys;
using WpfApp1.Infastructure.Services;

namespace WpfApp1.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly ProductService _productService;

        [ObservableProperty] List<Product> products;
        [ObservableProperty] Product selectedProduct;

        public MainWindowViewModel()
        {
            _productService = new ProductService();

            //_productService.AddProduct(@"E:\Литвин\Практика\WpfApp1\WpfApp1\Resuces\Img\Микроволновый датчик.jpg", "Микроволновый датчик");
            //_productService.AddProduct(@"E:\Литвин\Практика\WpfApp1\WpfApp1\Resuces\Img\Респиратор.jpg", "Респиратор");
            //_productService.AddProduct(@"E:\Литвин\Практика\WpfApp1\WpfApp1\Resuces\Img\Микроволновый датчик.jpg", "Микроволновый датчик");
            //_productService.AddProduct(@"E:\Литвин\Практика\WpfApp1\WpfApp1\Resuces\Img\Защита от холода.jpg", "Защита от холода");

            Init();
        }

        private async Task Init()
        {
          Products = await _productService.GetProducts();
        }

    }
}
