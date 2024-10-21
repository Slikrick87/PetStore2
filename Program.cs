
using PetStore;
using System;
using System.ComponentModel.Design;
using System.Text.Json;
using ProductLogic;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
//var productLogic = new ProductLogic();
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
            DogLeash newDogleash = new DogLeash();
            Console.Write("Name:");
            newDogleash.Name = Console.ReadLine();
            Console.Write("Price:");
            newDogleash.Price = int.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            newDogleash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            newDogleash.Description = Console.ReadLine();
            Console.Write("Length in inches:");
            newDogleash.LengthInches = int.Parse(Console.ReadLine());
            Console.Write("Material:");
            newDogleash.Material = Console.ReadLine();
           // productLogic.AddProduct();
            Console.WriteLine($"Product added: " + newDogleash.Name);
            Console.WriteLine(JsonSerializer.Serialize(newDogleash));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to add another Product");
            Console.WriteLine("Type exit to quit program");
            //Console.WriteLine(daRizzler.Name);
            userInput = Console.ReadLine();
        
        }
    else if (userInput == "8")
    {
        
       // ProductLogic.GetAllProducts();
    }
}
