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


            public static Product AddProduct(DogLeash dog_leash)
            {
                    List<Product> _products = new List<Product>();
                    _products.Add(new Product());
                    return new Product();
                
            }
            public static void GetAllProducts(List<Product> _products)
            {
                //foreach (Product product in list)
                //{
                    _products.ForEach((p) => Console.WriteLine(p));
                
                //}
            //return null;
            }
        }
    }


