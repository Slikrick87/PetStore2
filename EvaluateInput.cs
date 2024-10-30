using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using PetStore;

namespace PetStore
{
    public class EvaluateInput
    {
        //ProductLogic productLogic = new ProductLogic();
        public static void CheckInput(string userInput)
        {
            var ProductLogic = new ProductLogic();
            var DisplayProducts = new DisplayProducts();
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
                        Console.WriteLine("Enter product type:");
                        userInput = Console.ReadLine();
                        if (userInput.Trim().ToLower() == "dogleash")
                        {
                            Console.WriteLine("Enter Name of Dog Leash.");
                            userInput = Console.ReadLine();
                            ProductLogic.GetDogLeashByName(userInput);
                        }
                        else if (userInput.Trim().ToLower() == "catfood") ;
                        {
                            Console.WriteLine(" Enter Name of Cat Food.");
                            userInput = Console.ReadLine();
                            ProductLogic.GetCatFoodByName(userInput);
                        }
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine("hey");
                        DisplayProducts.GetAllProducts(ProductLogic._products);
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
