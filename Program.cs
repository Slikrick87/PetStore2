
using PetStore;
using System.ComponentModel.Design;

var productLogic = new ProductLogic(); //use lowercase to not confuse instance with class underline if private
                                   
        string userInput = "cool";
        var EvaluateInput = new EvaluateInput();
        //var ProductLogic = new ProductLogic();
        var DisplayProducts = new DisplayProducts();
while (userInput == null || userInput.ToLower().Trim() != "exit")
    {
        Console.WriteLine("Press 1 to add a product.");
        Console.WriteLine("Press 2 to search for product.");
        Console.WriteLine("Press 8 to view entered products");
        Console.WriteLine("Type 'exit' to quit");
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
                        newCatFood.NewCatFood(productLogic);
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
            case "8":
                {
                    DisplayProducts.GetAllProducts(productLogic._products);
                    continue;
                }
            default:
                {
                    break;
                }

        }
    }
    
