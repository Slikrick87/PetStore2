using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class newCatFood
    {
        public void NewCatFood() 
        {
            CatFood catFood = new CatFood();
            Console.Write("Name:");
            catFood.Name = Console.ReadLine().Trim();
            Console.Write("Price:");
            catFood.Price = int.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            catFood.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            catFood.Description = Console.ReadLine();
            Console.Write("Weight in pounds:");
            catFood.WeightPounds = int.Parse(Console.ReadLine());
            Console.Write("Safe for Kittens to eat?: Y/N");
            string Safe = Console.ReadLine();
            catFood.KittenFood = Safe.ToLower().Replace(" ", "").StartsWith("y");
            ProductLogic.AddProduct(catFood);
            Console.WriteLine($"Product added: " + catFood.Name);
            Console.WriteLine(JsonSerializer.Serialize(catFood));

        }
    }
}
