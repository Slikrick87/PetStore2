using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    internal class DisplayProducts
    {
        public void GetAllProducts(List<Product> _products)
        {
            foreach (CatFood product in _products.OfType<CatFood>())
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Product Name:    " + product.Name);
                Console.WriteLine($"Description:     " + product.Description);
                Console.WriteLine($"Price:           " + product.Price);
                Console.WriteLine($"Quantity:        " + product.Quantity);
                Console.WriteLine($"Weight:          " + product.WeightPounds + " lbs");
                Console.WriteLine($"Safe for Kittens:" + product.KittenFood);
                Console.WriteLine("------------------------------------------");
            }
            foreach (DogLeash product in _products.OfType<DogLeash>())
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Product Name:    " + product.Name);
                Console.WriteLine($"Description:     " + product.Description);
                Console.WriteLine($"Price:           " + product.Price);
                Console.WriteLine($"Quantity:        " + product.Quantity);
                Console.WriteLine($"Length:          " + product.LengthInches + "\"");
                Console.WriteLine($"Material:        " + product.Material);
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
