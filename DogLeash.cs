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
    public class DogLeashLogic : IDogLeash
    {
        public List<DogLeash> _DogLeashList = new();
        public Dictionary<String, DogLeash> _DogLeash = new(StringComparer.InvariantCultureIgnoreCase);
        public bool dogLeashSearchValid = false;

        public DogLeash NewDogLeash()
        {
            //DogLeash dog_leash = new DogLeash();
            Console.Write("Name:");                                  //Naming Dog Leash
            string dogLeashName = Console.ReadLine();

            string price;
            decimal dogLeashPrice;
            do
            {
                Console.Write("Price:");                             //Pricing Dog Leash
                price = Console.ReadLine();
            } while (!decimal.TryParse(price, out dogLeashPrice));
            dogLeashPrice = dogLeashPrice;

            string quantity;
            int dogLeashQuantity;
            do
            {
                Console.Write("Quantity:");                            //Quantifying Dog Leash Product
                quantity = Console.ReadLine();
            }
            while (!int.TryParse(quantity, out dogLeashQuantity));
            dogLeashQuantity = dogLeashQuantity;

            string dogLeashDescription;
            do {
                Console.Write("Description:");                              //Dog Leash Description
                dogLeashDescription = Console.ReadLine();
                } while (dogLeashDescription == null || dogLeashDescription == "");

            string length;
            int dogLeashLength;
            do
            {
                Console.Write("Length in inches:");                     //Dog Leash Length
                length = Console.ReadLine();
            }
            while (!int.TryParse(length.Replace("\"", ""), out dogLeashLength));
            dogLeashLength = dogLeashLength;

            Console.Write("Material:");                                 //Dog Leash Material
            string dogLeashMaterial = Console.ReadLine();

            DogLeash dogLeash = new DogLeash(dogLeashName, dogLeashPrice, dogLeashQuantity, dogLeashDescription, dogLeashLength, dogLeashMaterial);
            AddDogLeash(dogLeash);
            Console.WriteLine($"---------------------------------- New Product Added! ----------------------------------");
            GetDogLeashByName(dogLeash.Name);
            //ProductLogic.AddProduct(dog_leash);
            //Console.WriteLine(JsonSerializer.Serialize(dog_leash));
            return dogLeash;
        }



        public void GetDogLeashByName(string name)
        {
            try
            {
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine($"Name:                           {_DogLeash[name].Name}");
                Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
                Console.WriteLine($"Price:                          {_DogLeash[name].Price}");
                Console.WriteLine($"Discounted Price:               {_DogLeash[name].Price.DiscountThisPrice()}");
                Console.WriteLine($"Quantity:                       {_DogLeash[name].Quantity}");
                Console.WriteLine($"Length:                         {_DogLeash[name].LengthInches}\"");
                Console.WriteLine($"Material:                       {_DogLeash[name].Material}");
                Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                dogLeashSearchValid = true;
            }
            catch (KeyNotFoundException e)
            {
                dogLeashSearchValid = false;
                Console.WriteLine("\n                     * Dog Leash does not exist in database *                       \n");
                Console.WriteLine("----------------------------------------------------------------------------------------");
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
                        _DogLeash.TryGetValue(key, out var value);
                        Console.WriteLine("Enter new name:");
                        string newInput = Console.ReadLine();  ///changes and adds to list
                        dogLeashToEdit = _DogLeash[key];
                        value.Name = newInput;
                        string newKey = dogLeashToEdit.Name;
                        _DogLeash.Remove(key);
                        _DogLeash.Add(newKey, value);
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
            _DogLeashList.Add(dogLeash);
            _DogLeash.Add(dogLeash.Name, dogLeash as DogLeash);
            return dogLeash;
        }

        public void DisplayAllDogLeash(Dictionary<string, DogLeash> _DogLeash)
        {
            Console.WriteLine("--------------------------------- [Dog Leash Products] ---------------------------------");
            foreach (var dogLeashEntry in _DogLeash)
            {
                GetDogLeashByName(dogLeashEntry.Value.Name);
            }
        }
        //public Dictionary<string, DogLeash> GetOnlyInStockDogLeashes()
        //{
        //    Dictionary<string, DogLeash> inStockDogLeashNames = new();
        //    foreach (var dogLeashEntry in _DogLeash)
        //    {
        //        if (dogLeashEntry.Value.Quantity > 0) { inStockDogLeashNames.Add(dogLeashEntry.Value.Name, dogLeashEntry.Value); }
        //    }
        //    foreach (var inStockDL in inStockDogLeashNames)
        //    {
        //        Console.WriteLine(inStockDL.Value.Name);
        //    }
        //    return inStockDogLeashNames;
        //}
        public List<DogLeash> GetOnlyInStockDogLeashes()
        {
            return _DogLeashList.InStockDogLeashes();
           //return _DogLeash.Where(x => x.Value.Quantity > 0).Select(x => x.Value.Name).ToList();
        }
        public decimal GetDogLeashInventoryTotal()
        {
            return _DogLeashList.InStockDogLeashes().Select(dL => dL.Price * dL.Quantity).Sum();
        }
        public List<String> GetOutOfStockDogLeashes()  //try to get lambda to work with return somehow room to grow for sure
        {
            return _DogLeash.Where(p => p.Value.Quantity == 0).Select(p => p.Value.Name).ToList();
            ;
            
        }
    }
}

    




