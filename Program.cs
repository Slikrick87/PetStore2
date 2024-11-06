
using PetStore;
using System.ComponentModel.Design;




//public class Program
//{

//    public void Main()
//    {
                                //when making 

        string userInput = "cool";
        var DisplayProducts = new DisplayProducts();
        var catFoodClass = new CatFoodLogic();
        var dogLeashClass = new DogLeashLogic();
        TestCode.CatFoodRepo(catFoodClass);
        TestCode.DogLeashRepo(dogLeashClass);
while (userInput == null || userInput.ToLower().Trim() != "exit")
        {
            Console.WriteLine("------------------------------- [Please Select An Option] ------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("[1 Add Product]");
            Console.Write(" [2 Search]");
            Console.Write(" [7 To View Out Of Stock Products]");
            Console.WriteLine(" [8 View Product List]");
            Console.Write(" [9 For In Stock Products]");
            Console.Write(" [0 Edit Product]");
            Console.WriteLine(" [Type 'exit' to quit]");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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
                                //DogLeashLogic.AddDogLeash();
                                //productLogic.AddProduct();
                                break;
                            }
                            else if (userInput.ToLower().Replace(" ", "") == "2")
                            {
                                Console.WriteLine("You've Selected Cat Food.");
                                catFoodClass.NewCatFood();

                                //catFood.PrintCatFood();
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
                            userInput.ToLower().Replace(" ","");
                        } while (userInput != "dogleash" && userInput != "catfood");
                        switch (userInput)
                        {
                            case "dogleash":
                                {
                                    do
                                    {
                                        Console.WriteLine("Enter Name of Dog Leash.");
                                        userInput = Console.ReadLine();
                                        dogLeashClass.GetDogLeashByName(userInput.ToLower().Trim());

                                        continue;
                                    } while (dogLeashClass.dogLeashSearchValid == false);
                                    break;
                                }
                            case "catfood":
                                {
                                    do
                                    {
                                        Console.WriteLine("Enter Name of Cat Food.");
                                        userInput = Console.ReadLine();
                                        //CatFoodUI.GetCatFoodByName(catFoodClass, userInput.ToLower().Trim());

                                        continue;
                                    } while (catFoodClass.catFoodSearchValid == false);
                                    break;
                                }
                        }
                        break;
                    }
                case "8":
                    {
                        dogLeashClass.DisplayAllDogLeash(dogLeashClass._DogLeash);
                        catFoodClass.DisplayAllCatFood(catFoodClass._CatFood);
                        //DisplayProducts.GetAllProducts(productLogic._products);
                        continue;
                    }
        //case "**":
        //    {
        //        TestCode.CatFoodRepo(catFoodClass);
        //        TestCode.DogLeashRepo(dogLeashClass);
        //        continue;
        //    }
        case "9":
            {
                dogLeashClass.GetOnlyInStockDogLeashes();
                catFoodClass.GetOnlyInStockCatFood();
                continue;
            }
        case "10":
            {
                dogLeashClass.GetOutOfStockDogLeashes();
                catFoodClass.GetOutOfStockCatFood();
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
 
 

    
