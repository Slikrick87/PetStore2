using System.Collections.Generic;

namespace PetStore
{
    public class ProductLogic
    {
        public List<Product> _products = new List<Product>();
        public Dictionary<string, DogLeash> _DogLeash = new();
        public Dictionary<string, CatFood> _CatFood = new();
        public bool dogLeashSearchValid = false;
        public bool catFoodSearchValid = false;

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

        
        public void GetDogLeashByName(string name)
        {
            try
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Name:              " + _DogLeash[name].Name);
                //Console.WriteLine();
                Console.WriteLine($"Description:       " + _DogLeash[name].Description);
                Console.WriteLine($"Price:             " + _DogLeash[name].Price);
                Console.WriteLine($"Quantity:          " + _DogLeash[name].Quantity);
                Console.WriteLine($"Length:            " + _DogLeash[name].LengthInches + "\"");
                Console.WriteLine($"Material:          " + _DogLeash[name].Material);
                //Console.WriteLine($"Length:            " + _DogLeash[name].LengthInches +"\"");
                Console.WriteLine("----------------------------------------------");
                dogLeashSearchValid = true;
            }
            catch (KeyNotFoundException e) {
                dogLeashSearchValid = false;
                Console.WriteLine("\nDog Leash does not exist in database\n");
                Console.WriteLine("----------------------------------------------");
            }
        }
        
    
        public void GetCatFoodByName(string name)
            {
            try
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Name:              " + _CatFood[name].Name);
                Console.WriteLine($"Description:       " + _CatFood[name].Description);
                Console.WriteLine($"Price:             " + _CatFood[name].Price);
                Console.WriteLine($"Quantity:          " + _CatFood[name].Quantity);
                Console.WriteLine($"Weight:            " + _CatFood[name].WeightPounds + " lbs");
                Console.WriteLine($"Safe for Kittens:  " + _CatFood[name].KittenFood);
                Console.WriteLine("----------------------------------------------");
                catFoodSearchValid = true;
            }
            catch (KeyNotFoundException e)
            {
                catFoodSearchValid = false;
                //Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\nCat Food doesn't exist in database.\n");
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}


