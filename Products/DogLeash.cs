﻿using System;
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

        public DogLeash(string Name, decimal Price, int Quantity, string Description, int LengthInches, string Material)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Description = Description;
            this.LengthInches = LengthInches;
            this.Material = Material;
        }
    }
    //public class DogLeashLogic : ProductLogic, IDogLeash
    //{
    //    public List<DogLeash> _DogLeashList = new();
    //    public Dictionary<String, DogLeash> _DogLeash = new(StringComparer.InvariantCultureIgnoreCase);
    //    public bool dogLeashSearchValid = false;

    //    public DogLeash NewDogLeash()
    //    {
    //        string dogLeashName;
    //        do
    //        {
    //            Console.Write("Name:");                                  //Naming Dog Leash
    //            dogLeashName = Console.ReadLine();
    //        } while(string.IsNullOrWhiteSpace(dogLeashName));
    //        string price;
    //        decimal dogLeashPrice;
    //        do
    //        {
    //            Console.Write("Price:");                             //Pricing Dog Leash
    //            price = Console.ReadLine();
    //        } while (!decimal.TryParse(price, out dogLeashPrice));

    //        string quantity;
    //        int dogLeashQuantity;
    //        do
    //        {
    //            Console.Write("Quantity:");                            //Quantifying Dog Leash Product
    //            quantity = Console.ReadLine();
    //        }
    //        while (!int.TryParse(quantity, out dogLeashQuantity));

    //        string dogLeashDescription;
    //        do {
    //            Console.Write("Description:");                              //Dog Leash Description
    //            dogLeashDescription = Console.ReadLine();
    //            } while (string.IsNullOrWhiteSpace(dogLeashDescription));

    //        string length;
    //        int dogLeashLength;
    //        do
    //        {
    //            Console.Write("Length in inches:");                     //Dog Leash Length
    //            length = Console.ReadLine();
    //        }
    //        while (!int.TryParse(length.Replace("\"", ""), out dogLeashLength));

    //        string dogLeashMaterial;
    //        do
    //        {
    //            Console.Write("Material:");                                 //Dog Leash Material
    //            dogLeashMaterial = Console.ReadLine();
    //        } while (string.IsNullOrWhiteSpace(dogLeashMaterial));
    //        DogLeash dogLeash = new DogLeash(dogLeashName, dogLeashPrice, dogLeashQuantity, dogLeashDescription, dogLeashLength, dogLeashMaterial);
    //        AddDogLeash(dogLeash);
    //        Console.WriteLine($"---------------------------------- New Product Added! ----------------------------------");
    //        GetProductByName(dogLeash.Name);
    //        //ProductLogic.AddProduct(dog_leash);
    //        //Console.WriteLine(JsonSerializer.Serialize(dog_leash));
    //        return dogLeash;
    //    }



    //    public override void GetProductByName(string name)
    //    {
    //        try
    //        {
    //            Console.WriteLine("----------------------------------------------------------------------------------------");
    //            Console.WriteLine($"Name:                           {_DogLeash[name].Name}");
    //            Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
    //            Console.WriteLine($"Price:                          {_DogLeash[name].Price}");
    //            Console.WriteLine($"Discounted Price:               {_DogLeash[name].Price.DiscountThisPrice()}");
    //            Console.WriteLine($"Quantity:                       {_DogLeash[name].Quantity}");
    //            Console.WriteLine($"Length:                         {_DogLeash[name].LengthInches}\"");
    //            Console.WriteLine($"Material:                       {_DogLeash[name].Material}");
    //            Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
    //            Console.WriteLine("----------------------------------------------------------------------------------------");
    //            dogLeashSearchValid = true;
    //        }
    //        catch (KeyNotFoundException e)
    //        {
    //            dogLeashSearchValid = false;
    //            Console.WriteLine("\n                     * Dog Leash does not exist in database *                       \n");
    //            Console.WriteLine("----------------------------------------------------------------------------------------");
    //        }
    //    }
    //    public DogLeash EditProductDogLeash()
    //    {
    //        Console.WriteLine("Please enter name of dog leash:");
    //        string key = Console.ReadLine();
    //        DogLeash dogLeashToEdit = _DogLeash[key];
    //        Console.WriteLine("Please enter parameter to edit");
    //        string userInput = Console.ReadLine();
    //        switch (userInput.ToLower().Trim())
    //        {
    //            case "name":
    //                {
    //                    _DogLeash.TryGetValue(key, out var value);
    //                    Console.WriteLine("Enter new name:");
    //                    string newInput = Console.ReadLine();  ///changes and adds to list
    //                    dogLeashToEdit = _DogLeash[key];
    //                    value.Name = newInput;
    //                    string newKey = dogLeashToEdit.Name;
    //                    _DogLeash.Remove(key);
    //                    _DogLeash.Add(newKey, value);
    //                    break;
    //                }
    //            case "description":
    //                {
    //                    string newDescription;
    //                    do
    //                    {
    //                        Console.WriteLine("Enter new description:");
    //                        newDescription = Console.ReadLine();
    //                    }
    //                    while(string.IsNullOrEmpty(newDescription));
    //                    dogLeashToEdit.Description = newDescription;
    //                    break;
    //                }
    //            case "price":
    //                {
    //                    string newPrice;
    //                    decimal newDogLeashPrice;
    //                    do
    //                    {
    //                        Console.WriteLine("Enter new price:");
    //                        newPrice = Console.ReadLine();
    //                    }
    //                    while (!decimal.TryParse(newPrice, out newDogLeashPrice));
    //                    dogLeashToEdit.Price = newDogLeashPrice;
    //                    break;
    //                }
    //            case "quantity":
    //                {
    //                    string newQuantity;
    //                    int newDogLeashQuantity;
    //                    do
    //                    {
    //                        Console.WriteLine("Enter new Quantity:");
    //                        newQuantity = Console.ReadLine();
    //                    }
    //                    while (!int.TryParse(newQuantity, out newDogLeashQuantity));
    //                    dogLeashToEdit.Quantity = newDogLeashQuantity;
    //                    break;
    //                }
    //            case "length":
    //                {
    //                    string newLength;
    //                    int lengthInches;
    //                    do
    //                    {
    //                        Console.WriteLine("Enter Length in Inches:");
    //                        newLength = Console.ReadLine();
    //                    }
    //                    while (!int.TryParse(newLength, out lengthInches));
    //                    dogLeashToEdit.LengthInches = lengthInches;
    //                    break;
    //                }
    //            case "material":
    //                {
    //                    string newMaterial;
    //                    do
    //                    {
    //                        Console.WriteLine("Enter Updated Material");
    //                        newMaterial = Console.ReadLine();
    //                    }
    //                    while (string.IsNullOrWhiteSpace(newMaterial));
    //                    dogLeashToEdit.Material = newMaterial;
    //                    break;
    //                }
    //            default:
    //                {
    //                    Console.WriteLine("Error occured.");
    //                    break;
    //                }

    //        }
    //        return dogLeashToEdit;
    //    }
    //    public DogLeash AddDogLeash(DogLeash dogLeash)
    //    {
    //        _DogLeashList.Add(dogLeash);
    //        _DogLeash.Add(dogLeash.Name, dogLeash as DogLeash);
    //        return dogLeash;
    //    }

    //    public void DisplayAllDogLeash(Dictionary<string, DogLeash> _DogLeash)
    //    {
    //        Console.WriteLine("--------------------------------- [Dog Leash Products] ---------------------------------");
    //        foreach (var dogLeashEntry in _DogLeash)
    //        {
    //            GetProductByName(dogLeashEntry.Value.Name);
    //        }
    //    }
    //    public List<DogLeash> GetOnlyInStockDogLeashes()
    //    {
    //        return _DogLeashList.InStock();
    //    }
    //    public decimal GetDogLeashInventoryTotal()
    //    {
    //        return _DogLeashList.InStock().Select(dL => dL.Price * dL.Quantity).Sum();
    //    }
    //    public List<String> GetOutOfStockDogLeashes()  //try to get lambda to work with return somehow room to grow for sure
    //    {
    //        return _DogLeash.Where(p => p.Value.Quantity == 0).Select(p => p.Value.Name).ToList();
    //        ;
            
    //    }
    //}
}

    




