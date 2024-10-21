
using PetStore;
using System;
using System.ComponentModel.Design;
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
            DogLeash newDogLeash = new DogLeash();
            Console.Write("Name:");
            newDogLeash.Name = Console.ReadLine();
            Console.Write("Price:");
            newDogLeash.Price = int.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            newDogLeash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            newDogLeash.Description = Console.ReadLine();
            Console.Write("Length in inches:");
            newDogLeash.LengthInches = int.Parse(Console.ReadLine());
            Console.Write("Material:");
            newDogLeash.Material = Console.ReadLine();
            //AddProduct(newDogLeash);
            Console.WriteLine($"Product added: " + newDogLeash.Name);
            Console.WriteLine(JsonSerializer.Serialize(newDogLeash));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to add another Product");
            Console.WriteLine("Type exit to quit program");
            Console.WriteLine(newDogLeash.Name);
            userInput = Console.ReadLine();
        
        }
    /*else if (userInput == "8")
    {

       // GetAllProducts();
    }*/
}
