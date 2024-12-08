using System.Collections.Generic;
using PetStore;
using System;
namespace PetStore
{
    public class ProductLogic<T> : IProductLogic
    {
        public class Product
        {
            public string? Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string? Description { get; set; } // should i use a ? or =string.empty
        }
        
        public List<T> _products = new();
        bool validSearch;

        public T GetAllProducts()
        {
            return 
        }
        public void GetProductByName(string name)
        {
            int listCounter = 0;
            try
            {
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine($"Name:                           {_products[listCounter].Name}");
                Console.WriteLine($"Description:                    {_products[name].Value.Description}");
                Console.WriteLine($"Price:                          {_products[name].Price}");
                Console.WriteLine($"Discounted Price:               {_DogLeash[name].Price.DiscountThisPrice()}");
                Console.WriteLine($"Quantity:                       {_DogLeash[name].Quantity}");
                //Console.WriteLine($"Length:                         {_DogLeash[name].LengthInches}\"");
                //Console.WriteLine($"Material:                       {_DogLeash[name].Material}");
               // Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                validSearch = true;
            }
            catch (KeyNotFoundException e)
            {
                validSearch = false;
                Console.WriteLine("\n                     * Dog Leash does not exist in database *                       \n");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
        }
    }
    
}  


