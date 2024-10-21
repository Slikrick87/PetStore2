
using PetStore;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text.Json;
//using Logic;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
var productLogic = new Product();
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        Console.WriteLine("Please type Product type to be added.\n*Compatible Types: Dog Leash, Cat Food");
        string productType = Console.ReadLine();
        if (productType.ToLower().Replace(" ", "") == "dogleash")
        {
            DogLeash newDogLeash = new DogLeash();
            Console.Write("Name:");
            newDogLeash.Name = Console.ReadLine();
            Console.Write("Price:");
            newDogLeash.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            newDogLeash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            newDogLeash.Description = Console.ReadLine();
            Console.Write("Length in inches:");
            string length = Console.ReadLine();
            newDogLeash.LengthInches = int.Parse(length.Replace("\"", ""));
            Console.Write("Material:");
            newDogLeash.Material = Console.ReadLine();
            //AddProduct(newDogLeash);
            Console.WriteLine($"Product added: " + newDogLeash.Name);
            Console.WriteLine(JsonSerializer.Serialize(newDogLeash));
        }
        else if (productType.ToLower().Replace(" ","") == "catfood")
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
            if (Safe.ToLower().Replace(" ", "") == "yes") 
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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to add another Product");
            Console.WriteLine("Type exit to quit program");
            //Console.WriteLine(newDogLeash.Name);
            userInput = Console.ReadLine();
        
        }
    /*else if (userInput == "8")
    {

       // GetAllProducts();
    }*/
}
