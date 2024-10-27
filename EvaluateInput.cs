using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class EvaluateInput
    {
        
        public static void CheckInput(string userInput) 
        {
            var ProductLogic = new ProductLogic();
            switch (userInput)
            {
                case "1":
                    {
                        Console.WriteLine("Please type Product type to be added.\n*Compatible Types:Dog Leash, Cat Food");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower().Replace(" ", "") == "dogleash")
                        {
                            
                            newDogLeash.NewDogLeash(ProductLogic);
                        }
                        else if (userInput.ToLower().Replace(" ", "") == "catfood")
                        {
                            newCatFood.NewCatFood(ProductLogic);
                        }
                        break;
                    }
                case "2":
                    {
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine("hey");
                        ProductLogic.GetAllProducts(ProductLogic._products);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
