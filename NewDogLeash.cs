using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PetStore;
namespace PetStore
{
    public class newDogLeash
    {
        public static DogLeash NewDogLeash()
        {
            DogLeash dog_leash = new DogLeash();
            Console.Write("Name:");
            dog_leash.Name = Console.ReadLine();
            Console.Write("Price:");
            dog_leash.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Quantity:");
            dog_leash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            dog_leash.Description = Console.ReadLine();
            Console.Write("Length in inches:");
            string length = Console.ReadLine();
            dog_leash.LengthInches = int.Parse(length.Replace("\"", ""));
            Console.Write("Material:");
            dog_leash.Material = Console.ReadLine();
            ProductLogic.AddProduct(dog_leash);
            Console.WriteLine($"Product added: " + dog_leash.Name);
            Console.WriteLine(JsonSerializer.Serialize(dog_leash));
            return dog_leash;
        }
    }
}
