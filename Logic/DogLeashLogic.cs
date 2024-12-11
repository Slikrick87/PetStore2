using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using PetStore;
using PetStore.Validators;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace PetStore.Logic
{
    public class DogLeashLogic : ProductLogic, IDogLeash
    {
        public DogLeash NewDogLeash()
        {
            string dogLeashName;
            do
            {
                Console.Write("Name:");                                  //Naming Dog Leash
                dogLeashName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(dogLeashName));
            string price;
            decimal dogLeashPrice;
            do
            {
                Console.Write("Price:");                             //Pricing Dog Leash
                price = Console.ReadLine();
            } while (!decimal.TryParse(price, out dogLeashPrice));

            string quantity;
            int dogLeashQuantity;
            do
            {
                Console.Write("Quantity:");                            //Quantifying Dog Leash Product
                quantity = Console.ReadLine();
            }
            while (!int.TryParse(quantity, out dogLeashQuantity));

            string dogLeashDescription;
            do
            {
                Console.Write("Description:");                              //Dog Leash Description
                dogLeashDescription = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(dogLeashDescription));

            string length;
            int dogLeashLength;
            do
            {
                Console.Write("Length in inches:");                     //Dog Leash Length
                length = Console.ReadLine();
            }
            while (!int.TryParse(length.Replace("\"", ""), out dogLeashLength));

            string dogLeashMaterial;
            do
            {
                Console.Write("Material:");                                 //Dog Leash Material
                dogLeashMaterial = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(dogLeashMaterial));
            DogLeash dogLeash = new DogLeash(dogLeashName, dogLeashPrice, dogLeashQuantity, dogLeashDescription, dogLeashLength, dogLeashMaterial);
            AddDogLeash(dogLeash);
            Console.WriteLine($"---------------------------------- New Product Added! ----------------------------------");
            GetProductByName<DogLeash>(dogLeash.Name);
            //ProductLogic.AddProduct(dog_leash);
            //Console.WriteLine(JsonSerializer.Serialize(dog_leash));
            return dogLeash;
        }
        public DogLeash CreateNewDogLeashJson()
        {
            string jsonText;
            Console.WriteLine("Add new product using Json Using the following format as an example");
            Console.WriteLine("{ \"Price\": 58.89, \"Name\": \"Special dog leash\", \"Quantity\": 23, \n\"Description\": \"Magical leash that will help your dog not pull hard when going on walks\", \n\"Material\": \"Classified\", \"LengthInches\": 12 }");
            jsonText = Console.ReadLine();
            DogLeash dogLeash = JsonSerializer.Deserialize<DogLeash>(jsonText);
            AddDogLeash(dogLeash);
            return dogLeash;
        }
        public DogLeash AddDogLeash(DogLeash dogLeash)
        {
            ValidationResult results = dogLeashValidator.Validate(dogLeash);
            try
            {
                _products.Add(dogLeash);
                _dogLeash.Add(dogLeash.Name, dogLeash as DogLeash);
                dogLeashValidator.ValidateAndThrow(dogLeash);
            }
            catch (Exception e) {

                if (!results.IsValid)
                {
                    foreach (var failure in results.Errors)
                    {
                        Console.WriteLine("\nProperty " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                    }
                }
            }
            
            return dogLeash;
        }

        /// <summary>
        /// Edit function doesn't change item in list only in dictionary
        /// </summary>
        /// <returns></returns>
        public DogLeash EditProductDogLeash()
        {
            Console.WriteLine("Please enter name of dog leash:");
            string key = Console.ReadLine();
            DogLeash dogLeashToEdit = _dogLeash[key];
            Console.WriteLine("Please enter parameter to edit");
            string userInput = Console.ReadLine();
            switch (userInput.ToLower().Trim())
            {
                case "name":
                    {
                        _dogLeash.TryGetValue(key, out var value);
                        Console.WriteLine("Enter new name:");
                        string newInput = Console.ReadLine();  ///changes and adds to list
                        dogLeashToEdit = _dogLeash[key];
                        value.Name = newInput;
                        string newKey = dogLeashToEdit.Name;
                        _dogLeash.Remove(key);
                        _dogLeash.Add(newKey, value);
                        break;
                    }
                case "description":
                    {
                        string newDescription;
                        do
                        {
                            Console.WriteLine("Enter new description:");
                            newDescription = Console.ReadLine();
                        }
                        while (string.IsNullOrEmpty(newDescription));
                        dogLeashToEdit.Description = newDescription;
                        break;
                    }
                case "price":
                    {
                        string newPrice;
                        decimal newDogLeashPrice;
                        do
                        {
                            Console.WriteLine("Enter new price:");
                            newPrice = Console.ReadLine();
                        }
                        while (!decimal.TryParse(newPrice, out newDogLeashPrice));
                        dogLeashToEdit.Price = newDogLeashPrice;
                        break;
                    }
                case "quantity":
                    {
                        string newQuantity;
                        int newDogLeashQuantity;
                        do
                        {
                            Console.WriteLine("Enter new Quantity:");
                            newQuantity = Console.ReadLine();
                        }
                        while (!int.TryParse(newQuantity, out newDogLeashQuantity));
                        dogLeashToEdit.Quantity = newDogLeashQuantity;
                        break;
                    }
                case "length":
                    {
                        string newLength;
                        int lengthInches;
                        do
                        {
                            Console.WriteLine("Enter Length in Inches:");
                            newLength = Console.ReadLine();
                        }
                        while (!int.TryParse(newLength, out lengthInches));
                        dogLeashToEdit.LengthInches = lengthInches;
                        break;
                    }
                case "material":
                    {
                        string newMaterial;
                        do
                        {
                            Console.WriteLine("Enter Updated Material");
                            newMaterial = Console.ReadLine();
                        }
                        while (string.IsNullOrWhiteSpace(newMaterial));
                        dogLeashToEdit.Material = newMaterial;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error occurred.");
                        break;
                    }

            }
            return dogLeashToEdit;
        }
    }
}
