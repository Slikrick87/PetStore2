using System.Text.Json;

namespace PetStore
{
    public class newCatFood
    {
        public static CatFood NewCatFood(ProductLogic productLogic)
        {

            CatFood catFood = new CatFood();
            Console.Write("Name:");
            catFood.Name = Console.ReadLine().Trim();
            Console.Write("Price:");
            string price = Console.ReadLine();
            while (!decimal.TryParse(price, out decimal value))
            {
                Console.Write("Price:");
                price = Console.ReadLine();
                catFood.Price = value;
            }
            Console.Write("Quantity:");
            string quantity = Console.ReadLine();
            while (!int.TryParse(quantity, out int value))
            {
                Console.Write("Quantity:");
                quantity = Console.ReadLine();
                catFood.Quantity = value;
            }
            //catFood.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Description:");                      //tried using a class instead of a new instance of that classes logic. I
            catFood.Description = Console.ReadLine();
            Console.Write("Weight in pounds:");
            string weight = Console.ReadLine();
            while (!int.TryParse (weight, out int value))
            {
                Console.Write("weight in pounds:");
                weight = Console.ReadLine();
                catFood.WeightPounds = value;
            }
            
            //catFood.WeightPounds = int.Parse(Console.ReadLine());
            Console.WriteLine("Safe for Kittens to eat?: Y/N");
            string Safe = Console.ReadLine();
            catFood.KittenFood = Safe.ToLower().Replace(" ", "").StartsWith("y");
            productLogic.AddProduct(catFood);
            Console.WriteLine($"Product added: " + catFood.Name);
            productLogic.GetCatFoodByName(catFood.Name);
            //Console.WriteLine(JsonSerializer.Serialize(catFood));
            return catFood;
        }
    }
}
