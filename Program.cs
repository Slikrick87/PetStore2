﻿
using PetStore;
using System.ComponentModel.Design;
using PetStore.Logic;





public class Program
{

    static void Main(string[] args)
    {
        var program = new ProgramLogic();
        
        program.OpeningSequence();

        string userInput = "cool";
        var productLogic = new ProductLogic();
        var catFoodClass = new CatFoodLogic();
        var dogLeashClass = new DogLeashLogic();
        TestCode.CatFoodRepo(catFoodClass);
        TestCode.DogLeashRepo(dogLeashClass);
        while (userInput == null || userInput.ToLower().Trim() != "exit")
        {

            program.DisplayMenuInputOptions();

            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    {
                        do
                        {
                            Console.WriteLine("Select Product Type.\n[1:Dog Leash] [2:Cat Food]");
                            Console.Write("User Input:");
                            userInput = Console.ReadLine();

                            if (userInput.ToLower().Replace(" ", "") == "1")
                            {
                                Console.WriteLine("You've Selected Dog Leash");
                                dogLeashClass.NewDogLeash();
                                break;
                            }
                            else if (userInput.ToLower().Replace(" ", "") == "2")
                            {
                                Console.WriteLine("You've Selected Cat Food.");
                                catFoodClass.NewCatFood();

                                break;
                            }
                        } while (userInput.ToLower().Trim() != "1" && userInput.Trim() != "2");
                        continue;
                    }
                case "2":
                    {
                        do
                        {
                            Console.WriteLine("Enter product type:");
                            userInput = Console.ReadLine();
                            userInput = userInput.ToLower().Replace(" ", "");
                        } while (userInput != "dogleash" && userInput != "catfood");
                        switch (userInput)
                        {
                            case "dogleash":
                                {
                                    do
                                    {
                                        Console.WriteLine("Enter Name of Dog Leash.");
                                        userInput = Console.ReadLine();
                                        dogLeashClass.GetProductByName(userInput.ToLower().Trim());

                                        continue;
                                    } while (dogLeashClass.validSearch == false);
                                    break;
                                }
                            case "catfood":
                                {
                                    do
                                    {
                                        Console.WriteLine("Enter Name of Cat Food.");
                                        userInput = Console.ReadLine();
                                        catFoodClass.GetProductByName(userInput.ToLower().Trim());

                                        continue;
                                    } while (catFoodClass.validSearch == false);
                                    break;
                                }
                        }
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine($"\nTotal Price of Inventory: ${dogLeashClass.GetDogLeashInventoryTotal() + catFoodClass.GetCatFoodInventoryTotal()}\n");
                        continue;
                    }
                case "8":
                    {
                        dogLeashClass.DisplayAllDogLeash(DogLeashLogic._DogLeash);
                        catFoodClass.DisplayAllCatFood(CatFoodLogic._CatFood);
                        continue;
                    }
                case "9":
                    {
                        List <DogLeash> inStockDogLeashes = dogLeashClass.GetOnlyInStockDogLeashes();
                        List <CatFood> inStockCatFood = catFoodClass.GetOnlyInStockCatFood();
                        Console.WriteLine(String.Join("\n", inStockDogLeashes.Select(dL => dL.Name)));
                        Console.WriteLine(String.Join("\n", inStockCatFood.Select(cF => cF.Name)));
                        continue;
                    }
                case "10":
                    {
                        Console.WriteLine(String.Join("\n", dogLeashClass.GetOutOfStockDogLeashes()));
                        Console.WriteLine(String.Join("\n", catFoodClass.GetOutOfStockCatFood()));
                        continue;
                    }
                case "0":
                    {
                        Console.WriteLine("Please Enter Product Type:");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower().Replace(" ", "") == "dogleash")
                        {
                            dogLeashClass.EditProductDogLeash();
                        }
                        else if (userInput.ToLower().Replace(" ", "") == "catfood")
                        {
                            catFoodClass.EditProductCatFood();
                        }
                        continue;
                    }
                default:
                    {
                        break;
                    }

            }
        }
    }
}

    
