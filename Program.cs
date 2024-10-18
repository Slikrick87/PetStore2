
using PetStore;
using System.Text.Json;

Console.WriteLine("Press 1 to add a product.");
Console.WriteLine("Type 'exit' to quit");
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
        Console.WriteLine(JsonSerializer.Serialize(daRizzler));
        userInput = Console.ReadLine();
        Console.WriteLine("If adding another product press 1");
        Console.WriteLine("To quit type exit");
        userInput = Console.ReadLine();
    }
}