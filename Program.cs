
using PetStore;
using PetStore.TestCode;
using System.ComponentModel.Design;

var productLogic = new ProductLogic(); //use lowercase to not confuse instance with class underline if private
//var testCode = new TestCode();                                
        string userInput = "cool";
//var EvaluateInput = new EvaluateInput(); //we create a product logic and call it with new products
    //var ProductLogic = new ProductLogic();
    var DisplayProducts = new DisplayProducts();
while (userInput == null || userInput.ToLower().Trim() != "exit")
    {
        Console.WriteLine("------------------------------- [Please Select An Option] ------------------------------");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("[1 Add Product]");
        Console.Write(" [2 Search]");
        Console.Write(" [8 View Product List]");
        Console.Write(" [0 Edit Product]");
        Console.WriteLine(" [Type 'exit' to quit]");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        userInput = Console.ReadLine();
        //EvaluateInput.CheckInput(userInput);
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
                        newDogLeash.NewDogLeash(productLogic);
                        break;
                    }
                    else if (userInput.ToLower().Replace(" ", "") == "2")
                    {
                        Console.WriteLine("You've Selected Cat Food.");
                        var catFood = newCatFood.NewCatFood(productLogic);
                        catFood.PrintCatFood();
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
                Console.WriteLine("Please Enter Product Type:");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "dogleash")
                {
                    productLogic.EditProductDogLeash();
                }
                else if (userInput.ToLower().Trim() == "catfood")
                {
                    productLogic.EditProductCatFood();
                }
                    continue;
            }
        //case "*":
        //    {
        //        PetStore.TestCode.TestCodeDict();
        //    }
        default:
                {
                    break;
                }

        }
    }
    
