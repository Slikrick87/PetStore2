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
        //private List<Product>? _products { get;  init; }
        //public ProductLogic()
        
            public List <Product> _products = new List<Product>();


            public Product AddProduct(Product product)
            {
                    //List<Product> _products = new List<Product>();
                    _products.Add(product);
                    return product;
                    
            }
            public void GetAllProducts(List<Product> _products)
            {
            //foreach (Product product in list)
            //{
                foreach (Product product in _products) 
                {
                
                Console.WriteLine($"\nProduct Name:    " +  product.Name);
                Console.WriteLine($"Description:     " + product.Description);
                Console.WriteLine($"Price:           " + product.Price);
                Console.WriteLine($"Quantity:        " + product.Quantity);
                     if (product.GetType() == typeof(CatFood)) { }
                //return;
                }
            
                
                //}
            //return null;
            }
        }
    }


