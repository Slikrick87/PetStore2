using System.Collections.Generic;
using PetStore;
using System;
using System.Xml.Linq;
using PetStore.Logic;
namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        public class Product : IProductLogic
        {
            public string? Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public string? Description { get; set; } // should i use a ? or =string.empty
        }

        public Dictionary<String, Product> _products = new();
        public List<Product> _productsList = new();
        bool validSearch;

        public virtual void GetProductByName(String name)
        {
            try
            {
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine($"Name:                           {_products[name].Name}");
                Console.WriteLine($"Description:                    {_products[name].Description}");
                Console.WriteLine($"Price:                          {_products[name].Price}");
                Console.WriteLine($"Discounted Price:               {_products[name].Price.DiscountThisPrice()}");
                Console.WriteLine($"Quantity:                       {_products[name].Quantity}");
                //try { Console.WriteLine($"Safe for Kittens:               {_products[name].Value.KittenFood}");

                Console.WriteLine("----------------------------------------------------------------------------------------");

                validSearch = true;
            }
            catch (KeyNotFoundException e)
            {
                validSearch = false;
                Console.WriteLine("\nProduct doesn't exist in database.\n");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
        }
        //public void DisplayAllProducts()
        //{
        //    Program.dogLeashClass.DisplayAllDogLeash();
        //}
    }
}


