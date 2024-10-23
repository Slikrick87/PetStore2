using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetStore
{
    public class newCatFood
    {
        public void NewCatFood() 
        {
            CatFood newCatFood = new CatFood();
            Console.Write("Name:");
            newCatFood.Name = Console.ReadLine().Trim();
            Console.Write("Price:");
            newCatFood.Price = int.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            newCatFood.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            newCatFood.Description = Console.ReadLine();
            Console.Write("Weight in pounds:");
            newCatFood.WeightPounds = int.Parse(Console.ReadLine());
            Console.Write("Safe for Kittens to eat?: Y/N");
            string Safe = Console.ReadLine();
            if (Safe.ToLower().Replace(" ", "").StartsWith("y"))
            {
                newCatFood.KittenFood = true;
            }
            else
            {
                newCatFood.KittenFood = false;
            }
            //AddProduct(newDogLeash);
            Console.WriteLine($"Product added: " + newCatFood.Name);
            Console.WriteLine(JsonSerializer.Serialize(newCatFood));

        }
    }
}
