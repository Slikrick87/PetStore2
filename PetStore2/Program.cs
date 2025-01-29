
using PetStore;
using System.ComponentModel.Design;
using PetStore.Logic;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Net.Http.Headers;
using PetStore.Data;



public class Program
{

    static void Main(string[] args)
    {
        ///not certain that calling the actual Logic class was the right move here but bool valid
        ///search didn't exist in the Interface
        var serviceCollection = ServiceDependencyProvider.CreateProductServiceCollection();
        var repo = serviceCollection.GetService<PetStore.Data.IProductRepository>();
        var productLogic = serviceCollection.GetService<IProductLogic>();

        //var dogLeashServiceCollection = ServiceDependencyProvider.CreateDogLeashServiceCollection();
        var dogLeashClass = serviceCollection.GetService<IDogLeash>();

        //var catFoodServiceCollection = ServiceDependencyProvider.CreateCatFoodServiceCollection();
        var catFoodClass = serviceCollection.GetService<ICatFood>();
        //var repo = serviceCollection.GetService<PetStore.Data.IProductRepository>();
        var program = new ProgramLogic();
        
        program.OpeningSequence();

        string userInput = "cool";

        //should be replacing the instances of productLogic, Dogleashlogic, etc. with ServiceDependencyProvider.
        //var productLogic = new ProductLogic();
        //var catFoodClass = new CatFoodLogic();
        //var dogLeashClass = new DogLeashLogic();
        //ProductLogic.CatFoodRepo(productLogic);
        //ProductLogic.DogLeashRepo(dogLeashClass);




        while (userInput == null || userInput.ToLower().Trim() != "exit")
        {

            program.DisplayMenuInputOptions();

            userInput = Console.ReadLine();
            switch (userInput)
            {
                //case "1":
                //    {
                //        Console.WriteLine("please enter product type(Dog Leash, Cat Food)");
                //        string selection = Console.ReadLine();
                //        selection = selection.ToLower().Replace(" ", "");
                //        switch (selection.ToLower().Trim())
                //        {
                //            case "dogleash":
                //                {
                                    
                //                        Console.WriteLine("You've Selected Dog Leash");
                //                        dogLeashClass.NewDogLeash();
                //                        continue;
                                    
                //                }
                //            case "catfood":
                //                {
                                    
                //                        Console.WriteLine("You've Selected Cat Food By Field.");
                //                        catFoodClass.NewCatFood();
                //                        continue;
                                   
                //                }
                                
                //        }
                //        continue;
                //    }
                case "1":
                    {
                        ProductEntity newProduct = productLogic.NewProduct();
                        repo.AddProduct(newProduct);
                        continue;
                    }
                case "2":
                    {
                        repo.GetAllProducts();
                        continue;
                    }

                //case "2":
                //    {
                //        bool validSearch = false;
                //        do
                //        {
                //            Console.WriteLine("Enter product type:");
                //            userInput = Console.ReadLine();
                //            userInput = userInput.ToLower().Replace(" ", "");
                //        } while (userInput != "dogleash" && userInput != "catfood");
                //        switch (userInput)
                //        {
                //            case "dogleash":
                //                {
                //                    do
                //                    {
                //                        try
                //                        {
                //                            Console.WriteLine("Enter Name of Dog Leash.");
                //                            userInput = Console.ReadLine();
                //                            //dogLeashClass.GetDogLeashByName(userInput.ToLower().Trim());
                //                            //productLogic.DisplayProduct<DogLeash>(userInput);
                //                            validSearch = true;
                //                        } catch { validSearch = false; }
                                        
                //                        continue;
                //                    } while (validSearch == false);
                //                    break;
                //                }
                //            case "catfood":
                //                {
                //                    do
                //                    {
                //                        try
                //                        {
                //                            Console.WriteLine("Enter Name of Cat Food.");
                //                            userInput = Console.ReadLine();
                //                            //productLogic.DisplayProduct<CatFood>(userInput);
                //                            //and here to solve interface call issue have to change code around a bit
                //                            validSearch = true;
                //                        } catch { validSearch = false; }
                                            
                //                        continue;
                //                    } while (validSearch == false);
                //                    break;
                //                }
                //        }
                //        break;
                //    }
                case "3":
                    {
                        repo.GetNumberOfProducts();
                        continue;
                    }
                //case "7":
                //    {
                //        Console.WriteLine($"\nTotal Price of Inventory: ${productLogic.GetProductInventoryTotal()}\n");
                //        continue;
                //    }
                case "8":
                    {
                        repo.GetAllProducts();
                        continue;
                    }
                //case "9":
                //    {
                //        //List <Product> inStockProducts = productLogic.GetOnlyInStockProducts();
                //        //List <CatFood> inStockCatFood = catFoodClass.GetOnlyInStockCatFood();
                //        Console.WriteLine(String.Join("\n", inStockProducts.Select(dL => dL.Name)));
                //        //Console.WriteLine(String.Join("\n", inStockCatFood.Select(cF => cF.Name)));
                //        continue;
                //    }
                //case "10":
                //    {
                //        Console.WriteLine(String.Join("\n", productLogic.GetOutOfStockProducts()));
                //        //Console.WriteLine(String.Join("\n", catFoodClass.GetOutOfStockCatFood()));
                //        continue;
                //    }
                //case "0":
                //    {
                //        Console.WriteLine("Please Enter Product Type:");
                //        userInput = Console.ReadLine();
                //        if (userInput.ToLower().Replace(" ", "") == "dogleash")
                //        {
                //            dogLeashClass.EditProductDogLeash();
                //        }
                //        else if (userInput.ToLower().Replace(" ", "") == "catfood")
                //        {
                //            catFoodClass.EditProductCatFood();
                //        }
                //        continue;
                //    }
                default:
                    {
                        break;
                    }

            }
        }
    }
}


    
