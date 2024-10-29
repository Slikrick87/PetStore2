using System.Text.Json;
namespace PetStore
{
    public class newDogLeash
    {
        public static DogLeash NewDogLeash(ProductLogic productLogic)
        {   
            DogLeash dog_leash = new DogLeash();
            Console.Write("Name:");                                  //Naming Dog Leash
            dog_leash.Name = Console.ReadLine();

            string price;
            decimal dog_leashPrice;
            do
            {
                Console.Write("Price:");                             //Pricing Dog Leash
                price = Console.ReadLine();
            }while (!decimal.TryParse(price, out dog_leashPrice));
            dog_leash.Price = dog_leashPrice;
            
            string quantity;
            int dog_leashQuantity;
            do
            {
                Console.Write("Quantity:");                            //Quantifying Dog Leash Product
                quantity = Console.ReadLine();
            }
            while (!int.TryParse(quantity, out dog_leashQuantity));
            dog_leash.Quantity = dog_leashQuantity;
            
            Console.Write("Description:");                              //Dog Leash Description
            dog_leash.Description = Console.ReadLine();

            string length;
            int dog_leashLength;
            do
            {
                Console.Write("Length in inches:");                     //Dog Leash Length
                length = Console.ReadLine();
            }
            while (!int.TryParse(length.Replace("\"", ""), out dog_leashLength));
            dog_leash.LengthInches = dog_leashLength;
            
            Console.Write("Material:");                                 //Dog Leash Material
            dog_leash.Material = Console.ReadLine();
            
            productLogic.AddProduct(dog_leash);
            Console.WriteLine($"Product added: " + dog_leash.Name);
            productLogic.GetDogLeashByName(dog_leash.Name);
            //Console.WriteLine(JsonSerializer.Serialize(dog_leash));
            return dog_leash;
        }
    }
}
