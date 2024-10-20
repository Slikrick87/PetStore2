
using PetStore;
using System;
using System.ComponentModel.Design;
using System.Text.Json;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
var productLogic = new ProductLogic();
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        DogLeash daRizzler = new DogLeash();
        Console.Write("Name:");
        daRizzler.Name = Console.ReadLine();
        Console.Write("Price:");
        daRizzler.Price = int.Parse(Console.ReadLine());
        Console.Write("Quantity:");
        daRizzler.Quantity = int.Parse(Console.ReadLine());
        Console.Write("Description:");
        daRizzler.Description = Console.ReadLine();
        Console.Write("Length in inches:");
        daRizzler.LengthInches = int.Parse(Console.ReadLine());
        Console.Write("Material:");
        daRizzler.Material = Console.ReadLine();
        productLogic.AddProduct();
        Console.WriteLine($"Product added: " + daRizzler.Name );
        Console.WriteLine(JsonSerializer.Serialize(daRizzler));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press 1 to add another Product");
        Console.WriteLine("Type exit to quit program");
        //Console.WriteLine(daRizzler.Name);
        userInput = Console.ReadLine();
    }
    }
