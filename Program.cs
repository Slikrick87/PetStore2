
using PetStore;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
//using Logic;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
var productLogic = new Product();
string userInput = Console.ReadLine();

while (userInput.ToLower().Trim() != "exit")
{
    if (userInput == "1")
    {
        Console.WriteLine("Please type Product type to be added.\n*Compatible Types: Dog Leash, Cat Food");
        string productType = Console.ReadLine();
        if (productType.ToLower().Replace(" ", "") == "dogleash")
        {
            NewDogLeash dog_leash = new NewDogLeash();
            dog_leash.newDogLeash();

        }
        else if (productType.ToLower().Replace(" ","") == "catfood")
        {
            newCatFood cat_food = new newCatFood();
            cat_food.NewCatFood();

            //CatFood newCatFood = new CatFood();
            //Console.Write("Name:");
            //newCatFood.Name = Console.ReadLine().Trim();
            //Console.Write("Price:");
            //newCatFood.Price = int.Parse(Console.ReadLine());
            //Console.Write("Quantity:");
            //newCatFood.Quantity = int.Parse(Console.ReadLine());
            //Console.Write("Description:");
            //newCatFood.Description = Console.ReadLine();
            //Console.Write("Weight in pounds:");
            //newCatFood.WeightPounds = int.Parse(Console.ReadLine());
            //Console.Write("Safe for Kittens to eat?: Y/N");
            //string Safe = Console.ReadLine();
            //if (Safe.ToLower().Replace(" ", "") == "yes") 
            //{ 
            //    newCatFood.KittenFood = true; 
            //}
            //else 
            //{
            //    newCatFood.KittenFood = false;
            //}
            ////AddProduct(newDogLeash);
            //Console.WriteLine($"Product added: " + newCatFood.Name);
            //Console.WriteLine(JsonSerializer.Serialize(newCatFood));
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
