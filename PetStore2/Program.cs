
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
        var program = new ProgramLogic();
        
        program.OpeningSequence();

        string userInput = "cool";
        int WorkingOrderId;
        OrderEntity order = repo.GetOrderById(1);



        while (userInput == null || userInput.ToLower().Trim() != "exit")
        {

            program.DisplayMenuInputOptions();
            //OrderEntity order = null;
            int orderId = 0;
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    {
                        //OrderEntity context;
                        int OrderId = 0;
                        string input;
                        //OrderEntity? order;
                        do
                        {
                            Console.WriteLine("Please Input your OrderId. If new Order type \" NEW \" /n to exit input input \"exit\" ");

                            input = Console.ReadLine();
                            if (input.ToLower().Trim() == "new")
                            {
                                order = repo.NewOrder();
                                Console.WriteLine($"OrderId: {order.OrderId}");
                            }
                            //else if (input.ToLower().Trim() == "exit")
                            //{
                            //    break;
                            //}
                            else
                            {
                                try
                                {
                                    OrderId = int.Parse(input);
                                    order = repo.GetOrderById(OrderId);
                                    if (order.Products != null)
                                    {
                                        foreach (ProductEntity p in order.Products)
                                        {
                                            Console.WriteLine($"Product Name: {p.Name}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Order Is Empty");

                                    }
                                   
                                    continue;
                                }
                                catch
                                {
                                    Console.WriteLine("Order Does Not Exist! Try Again!");
                                    break; 
                                }
                                
                            }
                            break;
                        } while (input.ToLower().Trim() != "exit");

                        //ProductEntity newProduct = productLogic.NewProduct();
                        //repo.AddProductDb();
                        
                        continue;
                    }
                case "2":
                    {
                        do
                        {
                            if (order != null)
                            {
                                Console.WriteLine($"Current Order:" + order.OrderId);
                            }
                            
                            Console.WriteLine("Input Product Id. \nTo exit input input exit");
                            userInput = Console.ReadLine();
                            if (userInput.ToLower().Trim() == "exit")
                            {
                                continue;
                            }
                            else
                            {
                                try
                                {
                                    int id = int.Parse(userInput);
                                    ProductEntity product = repo.ProductById(id);
                                    if (product != null)
                                    {
                                        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                                        Console.WriteLine($"Add {product.Name} to Cart? (y/n)");
                                        string addToCart = Console.ReadLine();
                                        if (addToCart.ToLower() == "y")
                                        {
                                            try {
                                                repo.AddProductToOrder(order, product);
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Product Not Added");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Product Not Found");
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid Input");
                                }
                                continue;
                            }

                        } while (userInput.ToLower().Trim() != "exit");
                        continue;
                    }

                //case "3":
                //    {
                //        repo.GetAllProducts();
                //        continue;
                //    }

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
                        Console.WriteLine("Products in Database:" + repo.GetNumberOfProducts());
                        continue;
                    }
                //case "7":
                //    {
                //        Console.WriteLine($"\nTotal Price of Inventory: ${productLogic.GetProductInventoryTotal()}\n");
                //        continue;
                //    }
                case "4":
                    {
                        repo.GetAllProducts();
                        continue;
                    }
                case "5":
                    {
                        repo.GetAllOrders();
                        continue;
                    }
                case "6":
                    {
                        do
                        {
                            Console.WriteLine("Input OrderId of Order You'd Like to work with.");
                            userInput = Console.ReadLine();
                            //orderId = int.Parse(userInput);
                        } while (!int.TryParse(userInput, out WorkingOrderId));
                        WorkingOrderId = int.Parse(userInput);
                        order = repo.GetOrderById(WorkingOrderId);
                        
                        continue;
                    }
                case "7":
                    {
                        do {
                            Console.WriteLine("Input OrderId of Order You'd Like to View.");
                            userInput = Console.ReadLine();
                        } while ((!int.TryParse(userInput, out WorkingOrderId) && userInput.ToLower().Trim() != "exit"));
                        if (userInput.ToLower().Trim() == "exit")
                        {
                            break;
                        }
                        orderId = int.Parse(userInput);
                        order = repo.GetOrderById(orderId);
                        repo.DisplayProductsInOrder(order);
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
                case "0":
                    {
                        Console.WriteLine("Please Input Data For New Product");
                        ProductEntity newProduct = productLogic.NewProduct();
                        //string name;
                        //do 
                        //{
                        //    Console.WriteLine("Input Name");
                        //    name = Console.ReadLine();
                        //} while (string.IsNullOrWhiteSpace(name));
                        //do
                        //{
                        //    Console.WriteLine("Input Price");
                        //    userInput = Console.ReadLine();
                        //} while (!decimal.TryParse(userInput, out decimal price));
                        //do
                        //{
                        //    Console.WriteLine("Input Quantity");
                        //    userInput = Console.ReadLine();
                        //} while (!int.TryParse(userInput, out int quantity));
                        //do
                        //{
                        //    Console.WriteLine("Input Description");
                        //    name = Console.ReadLine();
                        //} while (string.IsNullOrWhiteSpace(name));
                        repo.AddProductDb(newProduct);
                        continue;
                    }
                case "exit":
                    {
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


    
