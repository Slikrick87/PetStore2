using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    internal class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                Console.WriteLine($"Product found: {product.Name}, Price: {product.Price}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
