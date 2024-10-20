using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;


namespace PetStore
{
    internal class ProductLogic
    {
        List<Product> _products = new List<Product>();

        public ProductLogic()
        {
            _products = new List<Product>();
        }
        public void AddProduct()
        { _products.Add(new Product()); }


        public List<Product> GetAllProducts()
        {
            return _products;
        }

    }

}

