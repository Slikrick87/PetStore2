using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public void GetCatFoodByName(string name)
    {
        try
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Name:              " + _CatFood[name].Name);
            Console.WriteLine($"Description:       " + _CatFood[name].Description);
            Console.WriteLine($"Price:             " + _CatFood[name].Price);
            Console.WriteLine($"Quantity:          " + _CatFood[name].Quantity);
            Console.WriteLine($"Weight:            " + _CatFood[name].WeightPounds + " lbs");
            Console.WriteLine($"Safe for Kittens:  " + _CatFood[name].KittenFood);
            Console.WriteLine("----------------------------------------------");
            catFoodSearchValid = true;
        }
        catch (KeyNotFoundException e)
        {
            catFoodSearchValid = false;
            Console.WriteLine("\nCat Food doesn't exist in database.\n");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
