using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class newCatFood
    {
        public static CatFood NewCatFood(ProductLogic productLogic) 
        {

            CatFood catFood = new CatFood();
            Console.Write("Name:");
            catFood.Name = Console.ReadLine().Trim();
            Console.Write("Price:");
            //string price = Console.ReadLine();
            catFood.Price = decimal.Parse(Console.ReadLine());
            /*
            bool cat = decimal.TryParse(Console.ReadLine(), out decimal Price);
            while (!cat)
                {
                    Console.Write("Price: ");
                    price = Console.ReadLine();
                    //catFood.Price = decimal.Parse(price);
                }
            */
            Console.Write("Quantity:");
            catFood.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");                      //tried using a class instead of a new instance of that classes logic. I
            catFood.Description = Console.ReadLine();
            Console.Write("Weight in pounds:");
            catFood.WeightPounds = int.Parse(Console.ReadLine());
            Console.WriteLine("Safe for Kittens to eat?: Y/N");
            string Safe = Console.ReadLine();
            catFood.KittenFood = Safe.ToLower().Replace(" ", "").StartsWith("y");
            productLogic.AddProduct(catFood);
            Console.WriteLine($"Product added: " + catFood.Name);
            Console.WriteLine(JsonSerializer.Serialize(catFood));
            return catFood;
        }
    }
}
