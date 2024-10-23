using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class NewDogLeash
    {
        public void newDogLeash(DogLeash dogLeash)
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
            ProductLogic.AddProduct(new NewDogLeash);
            Console.WriteLine($"Product added: " + newDogLeash.Name);
            Console.WriteLine(JsonSerializer.Serialize(newDogLeash));
        }
    }
}
