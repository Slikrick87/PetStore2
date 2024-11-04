
using PetStore;
using PetStore.TestCode;
using System.ComponentModel.Design;



    //public CatFoodLogic catFoodClass = new CatFoodLogic();
    //public DogLeashLogic dogLeashClass = new DogLeashLogic();
    //CatFoodLogic? catFoodClass { get; set; }
    //DogLeashLogic? dogLeashClass { get; set; }

   

        //var productLogic = new ProductLogic(); //use lowercase to not confuse instance with class underline                      
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
                                        catFoodClass.GetCatFoodByName(userInput.ToLower().Trim());

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
        case "*Test*":
            {
                //TestCode.TestRepository(dogLeashClass._DogLeash, catFoodClass._CatFood);


                DogLeash dogLeash1 = new DogLeash();
                dogLeash1.Name = "Da Rizzler";
                dogLeash1.Price = 14.99m;
                dogLeash1.Quantity = 87;
                dogLeash1.Description = "BadAss";
                dogLeash1.LengthInches = 12;
                dogLeash1.Material = "Leather";
                dogLeashClass.AddDogLeash(dogLeash1);
                //dogLeashClass._DogLeash.Add(dogLeash1.Name, dogLeash1);
                //_products.Add(dogLeash1);


                DogLeash dogLeash2 = new();
                dogLeash2.Name = "Lame AF";
                dogLeash2.Price = 9.99m;
                dogLeash2.Quantity = 20;
                dogLeash2.Description = "Pretty Lame";
                dogLeash2.LengthInches = 6;
                dogLeash2.Material = "Some Lame Crap";
                dogLeashClass.AddDogLeash(dogLeash2);
                //Dog_Leashes.Add(dogLeash2.Name, dogLeash2);
                //_products.Add(dogLeash2);

                CatFood catFood1 = new();
                catFood1.Name = "Pringles";
                catFood1.Price = 3.99m;
                catFood1.Quantity = 24;
                catFood1.Description = "Sour Cream and Onion";
                catFood1.WeightPounds = 1;
                catFood1.KittenFood = true;
                catFoodClass.AddCatFood(catFood1);
                //Cat_Food.Add(catFood1.Name, catFood1);
                //_products.Add(catFood1);

                CatFood catFood2 = new();
                catFood2.Name = "Kittie Chow";
                catFood2.Price = 19.99m;
                catFood2.Quantity = 24;
                catFood2.Description = "RoadKill";
                catFood2.WeightPounds = 100;
                catFood2.KittenFood = false;
                catFoodClass.AddCatFood(catFood2);
                //Cat_Food.Add(catFood2.Name, catFood2);
                //_products.Add(catFood2);

                CatFood catFood3 = new();
                catFood3.Name = "Spam";
                catFood3.Price = 5.99m;
                catFood3.Quantity = 72;
                catFood3.Description = "Shelf Stable!!";
                catFood3.WeightPounds = 3;
                catFood3.KittenFood = true;
                catFoodClass.AddCatFood(catFood3);
                //Cat_Food.Add(catFood3.Name, catFood3);
                //_products.Add(catFood3);

                DogLeash dogLeash3 = new();
                dogLeash3.Name = "The One Ring";
                dogLeash3.Price = 199.99m;
                dogLeash3.Quantity = 20;
                dogLeash3.Description = "Pretty Powerful";
                dogLeash3.LengthInches = 6;
                dogLeash3.Material = "Powerful Magic";
                dogLeashClass.AddDogLeash(dogLeash3);
                //Dog_Leashes.Add(dogLeash3.Name, dogLeash3);
                //_products.Add(dogLeash3);
                continue;
            }
        default:
                    {
                        break;
                    }

            }
        }
 

    
