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
        //public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
        public CatFood(string Name, decimal Price, int Quantity, string Description, bool KittenFood)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Description = Description;
            //this.WeightPounds = Weight;
            this.KittenFood = KittenFood;
        }
    }
    public class DryCatFood : CatFood
    {
        public double WeightPounds { get; set; }

        public DryCatFood(string Name, decimal Price, int Quantity, string Description, bool KittenFood, double Weight) : base(Name, Price, Quantity, Description, KittenFood)
        {
            //this.Name = Name;
            //this.Price = Price;
            //this.Quantity = Quantity;
            //this.Description = Description;
            //this.KittenFood= KittenFood;
            this.WeightPounds = Weight;
        }
    }

    public class CatFoodLogic : ICatFood
    {
        
        public Dictionary<string, CatFood> _CatFood = new(StringComparer.InvariantCultureIgnoreCase);
        public List<CatFood> _CatFoodList = new();
        public bool catFoodSearchValid = false;


        public CatFood NewCatFood()
            {
                
                Console.Write("Name:");
                string catFoodName = Console.ReadLine().Trim();

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
            do {
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
            //Console.WriteLine(JsonSerializer.Serialize(catFood));
            GetCatFoodByName(catFood.Name);
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
                            _CatFood.TryGetValue(key, out var value);
                        string newInput;
                        do
                        {
                            Console.WriteLine("Enter new name:");
                            newInput = Console.ReadLine();
                        } while (string.IsNullOrWhiteSpace(newInput));
                            //catFoodToEdit = _CatFood[key];
                            catFoodToEdit.Name = newInput;
                            string newKey = catFoodToEdit.Name;
                            _CatFood.Remove(key);
                            _CatFood.Add(newKey, value);
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
                    //case "weight":
                    //    {
                    //        string newWeight;
                    //        double Weight;
                    //        do
                    //        {
                    //            Console.WriteLine("Enter Updated Weight in pounds");
                    //            newWeight = Console.ReadLine();

                    //        }
                    //        while (!double.TryParse(newWeight, out Weight));
                    //        catFoodToEdit.WeightPounds = Weight;
                    //        break;
                    //    }
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
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine($"Name:                           { _CatFood[name].Name}");
                Console.WriteLine($"Description:                    {_CatFood[name].Description}");
                Console.WriteLine($"Price:                          {_CatFood[name].Price}");
                Console.WriteLine($"Discounted Price:               {_CatFood[name].Price.DiscountThisPrice()}");
                Console.WriteLine($"Quantity:                       {_CatFood[name].Quantity}");
                Console.WriteLine($"Safe for Kittens:               {_CatFood[name].KittenFood}");
                
                Console.WriteLine("----------------------------------------------------------------------------------------");
                
                catFoodSearchValid = true;
            }
            catch (KeyNotFoundException e)
            {
                catFoodSearchValid = false;
                Console.WriteLine("\nCat Food doesn't exist in database.\n");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
        }

        public CatFood AddCatFood(CatFood catFood)
        {
            _CatFoodList.Add(catFood);
            _CatFood.Add(catFood.Name, catFood as CatFood);
            return catFood;
        }
        public void DisplayAllCatFood(Dictionary<string, CatFood> _CatFood)
        {
            Console.WriteLine("--------------------------------- [Cat Food Products] ----------------------------------");
            foreach (var catFoodEntry in _CatFood)
            {
                GetCatFoodByName(catFoodEntry.Value.Name);
            }
        }
        public List<CatFood> GetOnlyInStockCatFood()
        {
            return _CatFoodList.InStock();
        }
        public decimal GetCatFoodInventoryTotal()
        {
            return _CatFoodList.InStock().Select(cF => cF.Price * cF.Quantity).Sum();
        }
        public List<String> GetOutOfStockCatFood()
        {
            return _CatFood.Where(p => p.Value.Quantity == 0).Select(p => p.Value.Name).ToList();
        }
    }
    }

