using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }
    public class CatFoodLogic
    {
        
        public Dictionary<string, CatFood> _CatFood = new();
        public bool catFoodSearchValid = false;
        public void PrintCatFood(CatFood catFood)
        {
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Product Name:    " + catFood.Name);
                Console.WriteLine($"Description:     " + catFood.Description);
                Console.WriteLine($"Price:           " + catFood.Price);
                Console.WriteLine($"Quantity:        " + catFood.Quantity);
                Console.WriteLine($"Weight:          " + catFood.WeightPounds + " lbs");
                Console.WriteLine($"Safe for Kittens:" + catFood.KittenFood);
                Console.WriteLine("------------------------------------------");
            }

        }

        public CatFood NewCatFood()
            {
                
            CatFood catFood = new CatFood();
                Console.Write("Name:");
                catFood.Name = Console.ReadLine().Trim();

                string price;
                decimal catFoodPrice;
                do
                {
                    Console.Write("Price:");
                    price = Console.ReadLine();
                }
                while (!decimal.TryParse(price, out catFoodPrice));
                catFood.Price = catFoodPrice;


                string quantity;
                int catFoodQuantity;
                do
                {
                    Console.Write("Quantity:");
                    quantity = Console.ReadLine();
                }
                while (!int.TryParse(quantity, out catFoodQuantity));
                catFood.Quantity = catFoodQuantity;


                Console.Write("Description:");                      //tried using a class instead of a new instance of that classes logic. I
                catFood.Description = Console.ReadLine();

                string weight;
                double catFoodWeight;
                do
                {
                    Console.Write("Weight in pounds:");
                    weight = Console.ReadLine();
                }
                while (!double.TryParse(weight, out catFoodWeight));
                catFood.WeightPounds = catFoodWeight;

                string Safe = "";
                do
                {
                    Console.WriteLine("Safe for Kittens to eat?: Y/N");
                    Safe = Console.ReadLine();
                }
                while (!Safe.ToLower().Replace(" ", "").StartsWith("y") && !Safe.ToLower().Replace(" ", "").StartsWith("n"));
                catFood.KittenFood = Safe.ToLower().Replace(" ", "").StartsWith("y");

                AddCatFood(catFood);
                //ProductLogic.AddProduct(catFood);
                Console.WriteLine($"Product added: " + catFood.Name);
                //GetCatFoodByName(catFood.Name);
                //Console.WriteLine(JsonSerializer.Serialize(catFood));
                PrintCatFood(catFood);
                return catFood;
            }
            public CatFood EditProductCatFood()
            {
                Console.WriteLine("Please enter name of Cat Food:");
                string key = Console.ReadLine();
                CatFood catFoodToEdit = _CatFood[key];
                Console.WriteLine("Please enter parameter to edit");
                string userInput = Console.ReadLine();
                switch (userInput.ToLower().Trim())
                {
                    case "name":
                        {
                            Console.WriteLine("Enter new name:");
                            string newInput = Console.ReadLine();
                            //dogLeashToEdit = _DogLeash[key];
                            catFoodToEdit.Name = newInput;
                            break;
                        }
                    case "description":
                        {
                            Console.WriteLine("Enter new description:");
                            string newDescription = Console.ReadLine();
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
                    case "weight":
                        {
                            string newWeight;
                            double Weight;
                            do
                            {
                                Console.WriteLine("Enter Updated Weight in pounds");
                                newWeight = Console.ReadLine();

                            }
                            while (!double.TryParse(newWeight, out Weight));
                            catFoodToEdit.WeightPounds = Weight;
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

        public void GetCatFoodByName(string name)
        {
            try
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Name:              " + _CatFood[name].Name);
                Console.WriteLine($"Description:       " + _CatFood[name].Description);
                Console.WriteLine($"Price:             " + _CatFood[name].Price);
                Console.WriteLine($"Quantity:          " + _CatFood[name].Quantity);
                Console.WriteLine($"Weight:            " + _CatFood[name].WeightPounds + " lbs");
                Console.WriteLine($"Safe for Kittens:  " + _CatFood[name].KittenFood);
                Console.WriteLine("----------------------------------------------");
                catFoodSearchValid = true;
            }
            catch (KeyNotFoundException e)
            {
                catFoodSearchValid = false;
                Console.WriteLine("\nCat Food doesn't exist in database.\n");
                Console.WriteLine("----------------------------------------------");
            }
        }

        public CatFood AddCatFood(CatFood catFood)
        {
            _CatFood.Add(catFood.Name, catFood as CatFood);
            return catFood;
        }
    }
    }

