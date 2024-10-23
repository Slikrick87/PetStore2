using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class ProductLogic
    {
        private List<Product>? _products;
        public ProductLogic()
        {
            _products = new List<Product>();
            new Product();



        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void GetAllProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(product);
            }

        }
    }
}


