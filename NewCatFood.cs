﻿using System.Text.Json;

namespace PetStore
{
    //public class newCatFood
    //{
    //    public static CatFood NewCatFood(ProductLogic productLogic)
    //    {

    //        CatFood catFood = new CatFood();
    //        Console.Write("Name:");
    //        catFood.Name = Console.ReadLine().Trim();

    //        string price;
    //        decimal catFoodPrice;
    //        do
    //        {
    //            Console.Write("Price:");
    //            price = Console.ReadLine();
    //        }
    //        while (!decimal.TryParse(price, out catFoodPrice));
    //        catFood.Price = catFoodPrice;
            

    //        string quantity;
    //        int catFoodQuantity;
    //        do
    //        {
    //            Console.Write("Quantity:");
    //            quantity = Console.ReadLine();
    //        }
    //        while (!int.TryParse(quantity, out catFoodQuantity));
    //        catFood.Quantity = catFoodQuantity; 
            
            
    //        Console.Write("Description:");                      //tried using a class instead of a new instance of that classes logic. I
    //        catFood.Description = Console.ReadLine();

    //        string weight;
    //        double catFoodWeight;
    //        do
    //        {
    //            Console.Write("Weight in pounds:");
    //            weight = Console.ReadLine();
    //        }
    //        while (!double.TryParse(weight, out catFoodWeight));
    //        catFood.WeightPounds = catFoodWeight;

    //        string Safe = "";
    //        do
    //        {
    //            Console.WriteLine("Safe for Kittens to eat?: Y/N");
    //            Safe = Console.ReadLine();
    //        }
    //        while (!Safe.ToLower().Replace(" ", "").StartsWith("y") && !Safe.ToLower().Replace(" ", "").StartsWith("n"));
    //        catFood.KittenFood = Safe.ToLower().Replace(" ", "").StartsWith("y");
            
    //        productLogic.AddProduct(catFood);
    //        Console.WriteLine($"Product added: " + catFood.Name);
    //        productLogic.GetCatFoodByName(catFood.Name);
    //        //Console.WriteLine(JsonSerializer.Serialize(catFood));
    //        return catFood;
    //    }
    //}
}
