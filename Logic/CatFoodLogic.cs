using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PetStore.Logic
{
    public class CatFoodLogic : ProductLogic, ICatFood
    {

        
        public CatFood NewCatFood()
        {

            Console.Write("Name:");
            string? catFoodName = Console.ReadLine().Trim();

            string price;
            decimal catFoodPrice;
            do
            {
                Console.Write("Price:");
                price = Console.ReadLine();
            }
            while (!decimal.TryParse(price, out catFoodPrice));


            string quantity;
            int catFoodQuantity;
            do
            {
                Console.Write("Quantity:");
                quantity = Console.ReadLine();
            }
            while (!int.TryParse(quantity, out catFoodQuantity));


            string catFoodDescription;
            do
            {
                Console.Write("Description:");                      //tried using a class instead of a new instance of that classes logic. I
                catFoodDescription = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(catFoodDescription));

            string weight;
            double catFoodWeight;
            do
            {
                Console.Write("Weight in pounds:");
                weight = Console.ReadLine();
            }
            while (!double.TryParse(weight, out catFoodWeight));

            string Safe = "";
            do
            {
                Console.WriteLine("Safe for Kittens to eat?: Y/N");
                Safe = Console.ReadLine();
            }
            while (!Safe.ToLower().Replace(" ", "").StartsWith("y") && !Safe.ToLower().Replace(" ", "").StartsWith("n"));
            bool KittenFood = Safe.StartsWith("y") ? true : false;

            CatFood catFood = new CatFood(catFoodName, catFoodPrice, catFoodQuantity, catFoodDescription, KittenFood);
            AddCatFood(catFood);

            Console.WriteLine($"--------------------------------- New Product Added! ----------------------------------");
            Console.WriteLine(GetProductByName<CatFood>(catFood.Name));
            //Console.WriteLine(JsonSerializer.Serialize(catFood));GetProductByName<CatFood>(catFood.Name);
            return catFood;
        }
        /// <summary>
        /// Edit Function doesn't change item in list only in Dictionary
        /// </summary>
        /// <returns></returns>
        public CatFood EditProductCatFood()
        {
            Console.WriteLine("Please enter name of Cat Food:");
            string key = Console.ReadLine();
            CatFood catFoodToEdit = _catFood[key];
            Console.WriteLine("Please enter parameter to edit");
            string? userInput = Console.ReadLine();
            switch (userInput.ToLower().Trim())
            {
                case "name":
                    {
                        _catFood.TryGetValue(key, out var value);
                        string newInput;
                        do
                        {
                            Console.WriteLine("Enter new name:");
                            newInput = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(newInput));
                        //catFoodToEdit = _CatFood[key];
                        catFoodToEdit.Name = newInput;
                        string newKey = catFoodToEdit.Name;
                        _catFood.Remove(key);
                        _catFood.Add(newKey, value);
                        
                        break;
                    }
                case "description":
                    {
                        string newDescription;
                        do
                        {
                            Console.WriteLine("Enter new description:");
                            newDescription = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(newDescription));
                        catFoodToEdit.Description = newDescription;
                        break;
                    }
                case "price":
                    {
                        string newPrice;
                        decimal newCatFoodPrice;
                        do
                        {
                            Console.WriteLine("Enter new price:");
                            newPrice = Console.ReadLine();
                        }
                        while (!decimal.TryParse(newPrice, out newCatFoodPrice));
                        catFoodToEdit.Price = newCatFoodPrice;
                        break;
                    }
                case "quantity":
                    {
                        string newQuantity;
                        int newCatFoodQuantity;
                        do
                        {
                            Console.WriteLine("Enter new Quantity:");
                            newQuantity = Console.ReadLine();
                        }
                        while (!int.TryParse(newQuantity, out newCatFoodQuantity));
                        catFoodToEdit.Quantity = newCatFoodQuantity;
                        break;
                    }
                case "safe for kittens":
                    {
                        string KittenFoodAnswer = null;
                        do
                        {
                            Console.WriteLine("Safe For Kittens: y/n?");
                            if (KittenFoodAnswer.StartsWith("y"))
                            {
                                catFoodToEdit.KittenFood = true;
                            }
                            else if (KittenFoodAnswer.ToLower().StartsWith("n"))
                            {
                                catFoodToEdit.KittenFood = false;
                            }
                        }
                        while (!KittenFoodAnswer.ToLower().StartsWith("n") || !KittenFoodAnswer.ToLower().StartsWith("y"));

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error occured.");
                        break;
                    }

            }
            return catFoodToEdit;
        }

        

        public CatFood AddCatFood(CatFood catFood)
        {
            _products.Add(catFood);
            _catFood.Add(catFood.Name, catFood as CatFood);
            return catFood;
        }
        public CatFood CreateNewCatFoodJson()
        {
            string jsonText;
            Console.WriteLine("Add new product using Json\nFields to enter");
            Console.WriteLine("{ \"Price\": 58.89, \"Name\": \"Special cat food\", \"Quantity\": 23, " +
                "\n\"Description\": \"Magical Cat Food that will keep your cat from acting wild at night\", " +
                "\n\"KittenFood\": \"true\" }");
            jsonText = Console.ReadLine();
            CatFood catFood = JsonSerializer.Deserialize<CatFood>(jsonText);
            AddCatFood(catFood);
            return catFood;
        }
    }
}
