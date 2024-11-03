
using PetStore;
using PetStore.TestCode;
using System.ComponentModel.Design;

//class Program
//{
//    static void Main(string[] args)
//    {

        var productLogic = new ProductLogic(); //use lowercase to not confuse instance with class underline                      
        string userInput = "cool";
        var DisplayProducts = new DisplayProducts();
        var catFoodClass = new CatFoodLogic();
        var dogLeashClass = new DogLeashLogic();
        //public List<Product> _products = new List<Product>();
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
                                        dogLeashClass.GetDogLeashByName(userInput.Trim());

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
                                        catFoodClass.GetCatFoodByName(userInput.Trim());

                                        continue;
                                    } while (catFoodClass.catFoodSearchValid == false);
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
                case "0":
                    {
                        Console.WriteLine("Please Enter Product Type:");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower().Trim() == "dogleash")
                        {
                            dogLeashClass.EditProductDogLeash();
                        }
                        else if (userInput.ToLower().Trim() == "catfood")
                        {
                            catFoodClass.EditProductCatFood();
                        }
                        continue;
                    }
                //case "*":
                //    {
                //        TestCode.TestCodeDict(dogLeashClass._DogLeash, catFoodClass._CatFood, productLogic._products);
                //        continue;
                //    }
                default:
                    {
                        break;
                    }

            }
        }
    

    
