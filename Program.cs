
using PetStore;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

//Console.WriteLine("Press 1 to add a product.");
//Console.WriteLine("Type 'exit' to quit");
var ProductLogic = new ProductLogic();
//string userInput = null;
string userInput = null; ;


while (userInput == null || userInput.ToLower().Trim() != "exit")
{
    Console.WriteLine("Press 1 to add a product.");
    Console.WriteLine("Press 8 to view entered products");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
    //if (userInput.ToLower().Trim() != "exit");
    //{ 
    //    //Console.WriteLine("Press 1 to add a product.");
    //    //Console.WriteLine("Type 'exit' to quit");
    //    //userInput = Console.ReadLine();

    //}
    if (userInput == "1")
    {
        Console.WriteLine("Please type Product type to be added.\n*Compatible Types: Dog Leash, Cat Food");
        userInput = Console.ReadLine();


        if (userInput.ToLower().Replace(" ", "") == "dogleash")
        {
            newDogLeash.NewDogLeash();
            //dog_leash.NewDogLeash();

        }
        else if (userInput.ToLower().Replace(" ", "") == "catfood")
        {
            newCatFood.NewCatFood();
            //cat_food.NewCatFood();
        }
        //userInput = Console.ReadLine();
    }
    else if (userInput == "8")
    {
        Console.WriteLine("hey");
        ProductLogic.GetAllProducts(ProductLogic._products);
    }

    
    
        //Console.WriteLine("Press 1 to add another Product");
        //Console.WriteLine("Press 8 to display list of added products");
        //Console.WriteLine("Type exit to quit program");
        //userInput = Console.ReadLine();
    
    }

