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

        //public Dictionary<string, DogLeash> _DogLeash = new();
        //public bool dogLeashSearchValid = false;
    }
    public class DogLeashLogic
    {
        public Dictionary<string, DogLeash> _DogLeash = new();
        public bool dogLeashSearchValid = false;

        public void PrintDogLeash(DogLeash dogLeash)
        {
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Product Name:    " + dogLeash.Name);
                Console.WriteLine($"Description:     " + dogLeash.Description);
                Console.WriteLine($"Price:           " + dogLeash.Price);
                Console.WriteLine($"Quantity:        " + dogLeash.Quantity);
                Console.WriteLine($"Weight:          " + dogLeash.LengthInches + " lbs");
                Console.WriteLine($"Safe for Kittens:" + dogLeash.Material);
                Console.WriteLine("------------------------------------------");
            }

        }

        public DogLeash NewDogLeash()
        {
            DogLeash dog_leash = new DogLeash();
            Console.Write("Name:");                                  //Naming Dog Leash
            dog_leash.Name = Console.ReadLine();

            string price;
            decimal dog_leashPrice;
            do
            {
                Console.Write("Price:");                             //Pricing Dog Leash
                price = Console.ReadLine();
            } while (!decimal.TryParse(price, out dog_leashPrice));
            dog_leash.Price = dog_leashPrice;

            string quantity;
            int dog_leashQuantity;
            do
            {
                Console.Write("Quantity:");                            //Quantifying Dog Leash Product
                quantity = Console.ReadLine();
            }
            while (!int.TryParse(quantity, out dog_leashQuantity));
            dog_leash.Quantity = dog_leashQuantity;

            Console.Write("Description:");                              //Dog Leash Description
            dog_leash.Description = Console.ReadLine();

            string length;
            int dog_leashLength;
            do
            {
                Console.Write("Length in inches:");                     //Dog Leash Length
                length = Console.ReadLine();
            }
            while (!int.TryParse(length.Replace("\"", ""), out dog_leashLength));
            dog_leash.LengthInches = dog_leashLength;

            Console.Write("Material:");                                 //Dog Leash Material
            dog_leash.Material = Console.ReadLine();

            AddDogLeash(dog_leash);
            Console.WriteLine($"Product added: " + dog_leash.Name);
            //GetDogLeashByName(dog_leash.Name);
            PrintDogLeash(dog_leash);
            //ProductLogic.AddProduct(dog_leash);
            //Console.WriteLine(JsonSerializer.Serialize(dog_leash));
            return dog_leash;
        }



        public void GetDogLeashByName(string name)
        {
            try
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Name:              " + _DogLeash[name].Name);
                Console.WriteLine($"Description:       " + _DogLeash[name].Description);
                Console.WriteLine($"Price:             " + _DogLeash[name].Price);
                Console.WriteLine($"Quantity:          " + _DogLeash[name].Quantity);
                Console.WriteLine($"Length:            " + _DogLeash[name].LengthInches + "\"");
                Console.WriteLine($"Material:          " + _DogLeash[name].Material);
                Console.WriteLine("----------------------------------------------");
                dogLeashSearchValid = true;
            }
            catch (KeyNotFoundException e)
            {
                dogLeashSearchValid = false;
                Console.WriteLine("\nDog Leash does not exist in database\n");
                Console.WriteLine("----------------------------------------------");
            }
        }
        public DogLeash EditProductDogLeash()
        {
            Console.WriteLine("Please enter name of dog leash:");
            string key = Console.ReadLine();
            DogLeash dogLeashToEdit = _DogLeash[key];
            Console.WriteLine("Please enter parameter to edit");
            string userInput = Console.ReadLine();
            switch (userInput.ToLower().Trim())
            {
                case "name":
                    {
                        Console.WriteLine("Enter new name:");
                        string newInput = Console.ReadLine();
                        //dogLeashToEdit = _DogLeash[key];
                        dogLeashToEdit.Name = newInput;
                        break;
                    }
                case "description":
                    {
                        Console.WriteLine("Enter new description:");
                        string newDescription = Console.ReadLine();
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
                        while (newMaterial == null || newMaterial == "");
                        dogLeashToEdit.Material = newMaterial;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error occured.");
                        break;
                    }

            }
            return dogLeashToEdit;
        }
        public DogLeash AddDogLeash(DogLeash dogLeash)
        {
            _DogLeash.Add(dogLeash.Name, dogLeash as DogLeash);
            //productLogic.AddProduct(dogLeash);
            return dogLeash;
        }

    }
}

    




