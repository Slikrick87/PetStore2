
using PetStore;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
var ProductLogic = new ProductLogic();
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
            dog_leash.newDogLeash(new DogLeash, Product);

        }
        else if (productType.ToLower().Replace(" ","") == "catfood")
        {
            newCatFood cat_food = new newCatFood();
            cat_food.NewCatFood();
        }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to add another Product");
            Console.WriteLine("Type exit to quit program");
            userInput = Console.ReadLine();
        
        }
    else if (userInput == "8")
    {

        ProductLogic.GetAllProducts();
    }
}
