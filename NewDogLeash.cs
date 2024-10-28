using System.Text.Json;
namespace PetStore
{
    public class newDogLeash
    {
        public static DogLeash NewDogLeash(ProductLogic productLogic)
        {
            DogLeash dog_leash = new DogLeash();
            Console.Write("Name:");
            dog_leash.Name = Console.ReadLine();
            Console.Write("Price:");
            string price = Console.ReadLine();
            while (!decimal.TryParse(price, out decimal value))
            {
                Console.Write("Price");
                price = Console.ReadLine();
                dog_leash.Price = value;
            }
            //dog_leash.Price = decimal.Parse(Console.ReadLine());
            //Console.Write("Quantity:");
            Console.Write("Quantity:");
            string quantity = Console.ReadLine();
            while (!int.TryParse(quantity, out int value))
            {
                Console.Write("Quantity:");
                quantity = Console.ReadLine();
                dog_leash.Quantity = value;
            }
            
            //dog_leash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");
            dog_leash.Description = Console.ReadLine();
            Console.Write("Length in inches:");
            string length = Console.ReadLine();
            while (!int.TryParse (length.Replace("\"", ""), out int value))
            {
                Console.Write("Length in inches:");
                length = Console.ReadLine();
                dog_leash.LengthInches = value;
            }
            //dog_leash.LengthInches = int.Parse(length.Replace("\"", ""));
            Console.Write("Material:");
            dog_leash.Material = Console.ReadLine();
            productLogic.AddProduct(dog_leash);
            Console.WriteLine($"Product added: " + dog_leash.Name);
            Console.WriteLine(JsonSerializer.Serialize(dog_leash));
            return dog_leash;
        }
    }
}
