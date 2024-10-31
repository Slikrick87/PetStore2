
using PetStore;
using System.ComponentModel.Design;

var productLogic = new ProductLogic(); //use lowercase to not confuse instance with class underline if private
                                   
        string userInput = "cool";
        var EvaluateInput = new EvaluateInput(); //we create a product logic and call it with new products
        var DisplayProducts = new DisplayProducts();
while (userInput == null || userInput.ToLower().Trim() != "exit")
    {
        Console.Write("[1 add a product]");
        Console.Write(" [2 to search]");
        Console.Write(" [8 to view entered products]");
        Console.Write(" [0 to Edit Product]");
        Console.WriteLine(" [Type 'exit' to quit]");
        Console.WriteLine();
        Console.Write("User Input:");
        userInput = Console.ReadLine();
        //EvaluateInput.CheckInput(userInput);
        switch (userInput)
        {
            case "1":
                {
                    Console.WriteLine("Please type Product type to be added.\n*Compatible Types:Dog Leash, Cat Food");
                Console.Write("User Input:");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower().Replace(" ", "") == "dogleash")
                    {

                        newDogLeash.NewDogLeash(productLogic);
                        break;
                    }
                    else if (userInput.ToLower().Replace(" ", "") == "catfood")
                    {
                    var catFood = newCatFood.NewCatFood(productLogic);
                    catFood.PrintCatFood();
                        break;
                    }
                    continue;
                }
            case "2":
            {
                do
                {
                    Console.WriteLine("Enter product type:");
                    userInput = Console.ReadLine();
                    userInput.Trim().ToLower();
                } while (userInput != "dogleash" && userInput != "catfood");
                switch (userInput)
                {
                    case "dogleash":
                        {
                            do
                            {
                                    Console.WriteLine("Enter Name of Dog Leash.");
                                    userInput = Console.ReadLine();
                                    productLogic.GetDogLeashByName(userInput.Trim());
                                
                                continue;
                            } while (productLogic.dogLeashSearchValid == false);
                            break;
                        }
                    case "catfood":
                        {
                            do
                            {
                                    Console.WriteLine("Enter Name of Cat Food.");
                                    userInput = Console.ReadLine();
                                    productLogic.GetCatFoodByName(userInput.Trim());
                                    
                                continue;
                            } while (productLogic.catFoodSearchValid == false);
                            break;
                        }
                }
                break;
            }
        //case "0":
        //    {
        //        userInput = Console.ReadLine();
        //        productLogic.EditProductDogLeash();
        //        continue;
        //    }
        case "8":
                {
                    DisplayProducts.GetAllProducts(productLogic._products);
                    continue;
                }
        case "0":
            {
                userInput = Console.ReadLine();
                productLogic.EditProductDogLeash();
                continue;
            }
        default:
                {
                    break;
                }

        }
    }
    
