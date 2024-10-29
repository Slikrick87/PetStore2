using System.Collections.Generic;

namespace PetStore
{
    public class ProductLogic
    {
        public List<Product> _products = new List<Product>();
        public Dictionary<string, DogLeash> _DogLeash = new();
        public Dictionary<string, CatFood> _CatFood = new();

        public Product AddProduct(Product product)
        {
            _products.Add(product);

            if (product.GetType() == typeof(CatFood))
            {
                    _CatFood.Add(product.Name, product as CatFood);
            }
            else if (product.GetType() == typeof(DogLeash))
            {
                _DogLeash.Add(product.Name, product as DogLeash);
            }
            return product;
        }
        public void GetAllProducts(List<Product> _products)
        {
                foreach (CatFood product in _products.OfType<CatFood>())
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Product Name:    " + product.Name);
                    Console.WriteLine($"Description:     " + product.Description);
                    Console.WriteLine($"Price:           " + product.Price);
                    Console.WriteLine($"Quantity:        " + product.Quantity);
                    Console.WriteLine($"Weight:          " + product.WeightPounds);
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
                Console.WriteLine($"Length:          " + product.LengthInches);
                Console.WriteLine($"Material:        " + product.Material);
                Console.WriteLine("------------------------------------------");
            }
        }

        public void GetDogLeashByName(string name)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Product Name:              " + _DogLeash[name].Name);
            Console.WriteLine($"Product Description:       " + _DogLeash[name].Description);
            Console.WriteLine($"Product Price:             " + _DogLeash[name].Price);
            Console.WriteLine($"Product Quantity:          " + _DogLeash[name].Quantity);
            Console.WriteLine($"Product Material:          " + _DogLeash[name].Material);
            Console.WriteLine($"Product Length:            " + _DogLeash[name].LengthInches +"\"");
            Console.WriteLine("----------------------------------------------");
        }
        public void GetCatFoodByName(string name)
            {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Product Name:              " + _CatFood[name].Name);
            Console.WriteLine($"Product Description:       " + _CatFood[name].Description);
            Console.WriteLine($"Product Price:             " + _CatFood[name].Price);
            Console.WriteLine($"Product Quantity:          " + _CatFood[name].Quantity);
            Console.WriteLine($"Product Weight:            " + _CatFood[name].WeightPounds + "lbs");
            Console.WriteLine($"Product Safe for Kittens:  " + _CatFood[name].KittenFood);
            Console.WriteLine("----------------------------------------------");
        }
    }
}


