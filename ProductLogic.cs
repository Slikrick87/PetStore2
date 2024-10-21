using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace ProductLogic
{
    public class Logic
    {
        private List<Product> _products = new List<Product>();

        public void ProductLogic()
        {
            _products = new List<Product>();

        }
        public void AddProduct(Product product)
        { _products.Add(new Product()); }
        public void GetAllProducts()
        {
            foreach (Product product in _products)
            {
                Console.WriteLine(_products);
            }
        }

    }
}


