
using PetStore;
using System.Text.Json;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    userInput = Console.ReadLine();
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
        Console.WriteLine(JsonSerializer.Serialize(daRizzler));
    }
    else if (userInput == "exit")
    {
        Console.WriteLine("Exitting PetStore. Press any key.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Not a valid input");
    }
}