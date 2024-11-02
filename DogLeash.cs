using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string? Material { get; set; }
    }
    public class dogLeash
    {

        //public static DogLeash NewDogLeash(ProductLogic productLogic)
        //{
        //    DogLeash dog_leash = new DogLeash();
        //    Console.Write("Name:");                                  //Naming Dog Leash
        //    dog_leash.Name = Console.ReadLine();

        //    string price;
        //    decimal dog_leashPrice;
        //    do
        //    {
        //        Console.Write("Price:");                             //Pricing Dog Leash
        //        price = Console.ReadLine();
        //    } while (!decimal.TryParse(price, out dog_leashPrice));
        //    dog_leash.Price = dog_leashPrice;

        //    string quantity;
        //    int dog_leashQuantity;
        //    do
        //    {
        //        Console.Write("Quantity:");                            //Quantifying Dog Leash Product
        //        quantity = Console.ReadLine();
        //    }
        //    while (!int.TryParse(quantity, out dog_leashQuantity));
        //    dog_leash.Quantity = dog_leashQuantity;

        //    Console.Write("Description:");                              //Dog Leash Description
        //    dog_leash.Description = Console.ReadLine();

        //    string length;
        //    int dog_leashLength;
        //    do
        //    {
        //        Console.Write("Length in inches:");                     //Dog Leash Length
        //        length = Console.ReadLine();
        //    }
        //    while (!int.TryParse(length.Replace("\"", ""), out dog_leashLength));
        //    dog_leash.LengthInches = dog_leashLength;

        //    Console.Write("Material:");                                 //Dog Leash Material
        //    dog_leash.Material = Console.ReadLine();

        //    productLogic.AddProduct(dog_leash);
        //    Console.WriteLine($"Product added: " + dog_leash.Name);
        //    dogLeash.GetDogLeashByName(dog_leash.Name);
        //    //Console.WriteLine(JsonSerializer.Serialize(dog_leash));
        //    return dog_leash;
        //}

        public class GetDogLeash
        {
            //public void GetDogLeashByName(string name)
            //{

            //    bool dogLeashSearchValid = false;
            //    try
            //    {
            //        Console.WriteLine("----------------------------------------------");
            //        Console.WriteLine($"Name:              " + _DogLeash[name].Name);
            //        Console.WriteLine($"Description:       " + _DogLeash[name].Description);
            //        Console.WriteLine($"Price:             " + _DogLeash[name].Price);
            //        Console.WriteLine($"Quantity:          " + _DogLeash[name].Quantity);
            //        Console.WriteLine($"Length:            " + _DogLeash[name].LengthInches + "\"");
            //        Console.WriteLine($"Material:          " + _DogLeash[name].Material);
            //        Console.WriteLine("----------------------------------------------");
            //        dogLeashSearchValid = true;
            //    }
            //    catch (KeyNotFoundException e)
            //    {
            //        dogLeashSearchValid = false;
            //        Console.WriteLine("\nDog Leash does not exist in database\n");
            //        Console.WriteLine("----------------------------------------------");
            //    }
            //}
        }
    }
}
