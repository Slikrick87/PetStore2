using System.Collections.Generic;
using PetStore;

namespace PetStore
{
    public class ProductLogic
    {
        //public List<Product> _products = new List<Product>();
        

        //public Product AddProduct()
        //{
            //_products.Add(product);

            //if (product.GetType() == typeof(CatFood))
            //{
            //    ;
            //    CatFoodLogic.AddCatFood(product.Name, product as CatFood);

            //}
            //else if (product.GetType() == typeof(DogLeash))
            //{
            //    _dogLeashLogic._DogLeash.Add(product.Name, product as DogLeash);
            //}
           // return product;
        //}
        //public void GetAllProducts(List<Product> _products)
        //{
        //    foreach (CatFood product in _products.OfType<CatFood>())
        //    {
        //        Console.WriteLine("------------------------------------------");
        //        Console.WriteLine($"Product Name:    " + product.Name);
        //        Console.WriteLine($"Description:     " + product.Description);
        //        Console.WriteLine($"Price:           " + product.Price);
        //        Console.WriteLine($"Quantity:        " + product.Quantity);
        //        Console.WriteLine($"Weight:          " + product.WeightPounds + " lbs");
        //        Console.WriteLine($"Safe for Kittens:" + product.KittenFood);
        //        Console.WriteLine("------------------------------------------");
        //    }
        //    foreach (DogLeash product in _products.OfType<DogLeash>())
        //    {
        //        Console.WriteLine("------------------------------------------");
        //        Console.WriteLine($"Product Name:    " + product.Name);
        //        Console.WriteLine($"Description:     " + product.Description);
        //        Console.WriteLine($"Price:           " + product.Price);
        //        Console.WriteLine($"Quantity:        " + product.Quantity);
        //        Console.WriteLine($"Length:          " + product.LengthInches + "\"");
        //        Console.WriteLine($"Material:        " + product.Material);
        //        Console.WriteLine("------------------------------------------");
        //    }
        //}


        //public void GetDogLeashByName(string name)
        //{
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


        //public void GetCatFoodByName(string name)
        //{
        //    try
        //    {
        //        Console.WriteLine("----------------------------------------------");
        //        Console.WriteLine($"Name:              " + _CatFood[name].Name);
        //        Console.WriteLine($"Description:       " + _CatFood[name].Description);
        //        Console.WriteLine($"Price:             " + _CatFood[name].Price);
        //        Console.WriteLine($"Quantity:          " + _CatFood[name].Quantity);
        //        Console.WriteLine($"Weight:            " + _CatFood[name].WeightPounds + " lbs");
        //        Console.WriteLine($"Safe for Kittens:  " + _CatFood[name].KittenFood);
        //        Console.WriteLine("----------------------------------------------");
        //        catFoodSearchValid = true;
        //    }
        //    catch (KeyNotFoundException e)
        //    {
        //        catFoodSearchValid = false;
        //        Console.WriteLine("\nCat Food doesn't exist in database.\n");
        //        Console.WriteLine("----------------------------------------------");
        //    }
        //}
        //public DogLeash EditProductDogLeash()
        //{
        //    Console.WriteLine("Please enter name of dog leash:");
        //    string key = Console.ReadLine();
        //    DogLeash dogLeashToEdit = _DogLeash[key];
        //    Console.WriteLine("Please enter parameter to edit");
        //    string userInput = Console.ReadLine();
        //    switch (userInput.ToLower().Trim())
        //    {
        //        case "name":
        //            {
        //                Console.WriteLine("Enter new name:");
        //                string newInput = Console.ReadLine();
        //                //dogLeashToEdit = _DogLeash[key];
        //                dogLeashToEdit.Name = newInput;
        //                break;
        //            }
        //        case "description":
        //            {
        //                Console.WriteLine("Enter new description:");
        //                string newDescription = Console.ReadLine();
        //                dogLeashToEdit.Description = newDescription;
        //                break;
        //            }
        //        case "price":
        //            {
        //                string newPrice;
        //                decimal newDogLeashPrice;
        //                do
        //                {
        //                    Console.WriteLine("Enter new price:");
        //                    newPrice = Console.ReadLine();
        //                }
        //                while (!decimal.TryParse(newPrice, out newDogLeashPrice));
        //                dogLeashToEdit.Price = newDogLeashPrice;
        //                break;
        //            }
        //        case "quantity":
        //            {
        //                string newQuantity;
        //                int newDogLeashQuantity;
        //                do
        //                {
        //                    Console.WriteLine("Enter new Quantity:");
        //                    newQuantity = Console.ReadLine();
        //                }
        //                while (!int.TryParse(newQuantity, out newDogLeashQuantity));
        //                dogLeashToEdit.Quantity = newDogLeashQuantity;
        //                break;
        //            }
        //        case "length":
        //            {
        //                string newLength;
        //                int lengthInches;
        //                do
        //                {
        //                    Console.WriteLine("Enter Length in Inches:");
        //                    newLength = Console.ReadLine();
        //                }
        //                while (!int.TryParse(newLength, out lengthInches));
        //                dogLeashToEdit.LengthInches = lengthInches;
        //                break;
        //            }
        //        case "material":
        //            {
        //                string newMaterial;
        //                do
        //                {
        //                    Console.WriteLine("Enter Updated Material");
        //                    newMaterial = Console.ReadLine();
        //                }
        //                while (newMaterial == null || newMaterial == "") ;
        //                dogLeashToEdit.Material = newMaterial;
        //                break;
        //            }
        //        default:
        //            {
        //                Console.WriteLine("Error occured.");
        //                break;
        //            }

        //    }
        //    return dogLeashToEdit;
        //}
        //public CatFood EditProductCatFood()
        //{
        //    Console.WriteLine("Please enter name of Cat Food:");
        //    string key = Console.ReadLine();
        //    CatFood catFoodToEdit = _CatFood[key];
        //    Console.WriteLine("Please enter parameter to edit");
        //    string userInput = Console.ReadLine();
        //    switch (userInput.ToLower().Trim())
        //    {
        //        case "name":
        //            {
        //                Console.WriteLine("Enter new name:");
        //                string newInput = Console.ReadLine();
        //                //dogLeashToEdit = _DogLeash[key];
        //                catFoodToEdit.Name = newInput;
        //                break;
        //            }
        //        case "description":
        //            {
        //                Console.WriteLine("Enter new description:");
        //                string newDescription = Console.ReadLine();
        //                catFoodToEdit.Description = newDescription;
        //                break;
        //            }
        //        case "price":
        //            {
        //                string newPrice;
        //                decimal newCatFoodPrice;
        //                do
        //                {
        //                    Console.WriteLine("Enter new price:");
        //                    newPrice = Console.ReadLine();
        //                }
        //                while (!decimal.TryParse(newPrice, out newCatFoodPrice));
        //                catFoodToEdit.Price = newCatFoodPrice;
        //                break;
        //            }
        //        case "quantity":
        //            {
        //                string newQuantity;
        //                int newCatFoodQuantity;
        //                do
        //                {
        //                    Console.WriteLine("Enter new Quantity:");
        //                    newQuantity = Console.ReadLine();
        //                }
        //                while (!int.TryParse(newQuantity, out newCatFoodQuantity));
        //                catFoodToEdit.Quantity = newCatFoodQuantity;
        //                break;
        //            }
        //        case "weight":
        //            {
        //                string newWeight;
        //                double Weight;
        //                do
        //                {
        //                    Console.WriteLine("Enter Updated Weight in pounds");
        //                    newWeight = Console.ReadLine();

        //                }
        //                while (!double.TryParse(newWeight, out Weight));
        //                catFoodToEdit.WeightPounds = Weight;
        //                break;
        //            }
        //        case "safe for kittens":
        //            {
        //                string KittenFoodAnswer = null;
        //                do
        //                {
        //                    Console.WriteLine("Safe For Kittens: y/n?");
        //                    if (KittenFoodAnswer.StartsWith("y"))
        //                    {
        //                        catFoodToEdit.KittenFood = true;
        //                    }
        //                    else if (KittenFoodAnswer.ToLower().StartsWith("n"))
        //                    {
        //                        catFoodToEdit.KittenFood = false;
        //                    }
        //                }
        //                while (!KittenFoodAnswer.ToLower().StartsWith("n") || !KittenFoodAnswer.ToLower().StartsWith("y"));

        //                break;
        //            }
        //        default:
        //            {
        //                Console.WriteLine("Error occured.");
        //                break;
        //            }

        //    }
        //    return catFoodToEdit;
        //}
    }
    
}  


