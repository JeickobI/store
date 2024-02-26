using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Entitys;
using WpfApp1.Infastructure.Data;

namespace WpfApp1.Infastructure.Services
{
    public class ProductService
    {
        private readonly StoreDbContext _context;
        public ProductService()
        { 
            _context = new StoreDbContext();
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Product.ToListAsync();   
        }

        public void AddProduct(string path, string name)
        {
            _context.Product.Add(new Entitys.Product
            {
                Name = name,
                Foto = File.ReadAllBytes(path),
            });

            _context.SaveChanges();
        }
    }
}
