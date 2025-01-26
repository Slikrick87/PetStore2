using PetStore.Data;
using PetStore.Logic;
using PetStore.Validators;
namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _IRepo;
        public Dictionary<String, DogLeash> _dogLeash = new(StringComparer.InvariantCultureIgnoreCase);
        public Dictionary<String, CatFood> _catFood = new(StringComparer.InvariantCultureIgnoreCase);
        public Dictionary<String, DryCatFood> _dryCatFood = new(StringComparer.InvariantCultureIgnoreCase);
        public List<Product> _products = new();

        public DogLeashValidator dogLeashValidator = new DogLeashValidator();
        public CatFoodValidator catFoodValidator = new CatFoodValidator();

        public ProductLogic(IProductRepository Repo)
        {
            _IRepo = Repo;
            _products = new List<Product>();
            _dogLeash = new Dictionary<String, DogLeash>();
            

            DogLeash dogLeash1 = new DogLeash("Da Rizzler", 14.99m, 87, "BadAss", 12, "Leather");
                _dogLeash.Add(dogLeash1.Name, dogLeash1);
                _products.Add(dogLeash1);
                DogLeash dogLeash2 = new DogLeash("Lame AF", 9.99m, 20, "Pretty Lame", 6, "Some Lame Crap");
                _dogLeash.Add(dogLeash2.Name, dogLeash2);
                _products.Add(dogLeash1);
                DogLeash dogLeash3 = new DogLeash("The One Ring", 199.99m, 0, "Pretty Powerful", 6, "Powerful Magic");
                _dogLeash.Add(dogLeash3.Name, dogLeash3);
                _products.Add(dogLeash1);
            

            _catFood = new Dictionary<String, CatFood>();
            
                CatFood catFood4 = new CatFood("Meowzer", 29.99m, 0, "CharBroiled", true);
                _catFood.Add(catFood4.Name, catFood4);
                _products.Add(catFood4);
                CatFood catFood1 = new CatFood("Pringles", 3.99m, 24, "Sour Cream and Onion", true);
                _catFood.Add(catFood1.Name, catFood1);
                _products.Add(catFood1);
                CatFood catFood2 = new CatFood("Kittie Chow", 19.99m, 24, "RoadKill", false);
                _catFood.Add(catFood2.Name, catFood2);
                _products.Add(catFood2);
                CatFood catFood3 = new CatFood("Spam", 5.99m, 72, "Shelf Stable!!", true);
                _catFood.Add(catFood3.Name, catFood3);
                _products.Add(catFood3);

            _dryCatFood = new Dictionary<String, DryCatFood>();
            DryCatFood dryCatFood1 = new DryCatFood("Shrimp Meal", 9.99m, 16, "Wild Caught.", true, 5);
            _products.Add(dryCatFood1);
            _dryCatFood.Add(dryCatFood1.Name, dryCatFood1);


        }
        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood)
            {
                _catFood.Add(product.Name, product as CatFood);
            }
            _products.Add(product);
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
        public List<Product> GetOnlyInStockProducts()
        {
            return _products.InStock();
        }
        public decimal GetProductInventoryTotal()
        {
            return _products.InStock().Select(p => p.Price * p.Quantity).Sum();
        } //definitely wrong total price or my math is bad
        public List<String> GetOutOfStockProducts()
        {
            return _products.Where(p => p.Quantity == 0).Select(p => p.Name).ToList();
        }
        public T GetProductByName<T>(string name) where T : Product
        {
            if (typeof(T) == typeof(DogLeash))
            {
                return _dogLeash[name] as T;
            }
            else if (typeof(T) == typeof(CatFood))
            {
                return _catFood[name] as T;
            }
            return null;
        }
        public void DisplayProduct<T>(string name) where T : Product
        {
            if (typeof(T) == typeof(DogLeash))
            {
                try
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Name:                           {_dogLeash[name].Name}");
                    Console.WriteLine($"Description:                    {_dogLeash[name].Description}");
                    Console.WriteLine($"Price:                          {_dogLeash[name].Price}");
                    Console.WriteLine($"Discounted Price:               {_dogLeash[name].Price.DiscountThisPrice()}");
                    Console.WriteLine($"Quantity:                       {_dogLeash[name].Quantity}");
                    Console.WriteLine($"Length:                         {_dogLeash[name].LengthInches}\"");
                    Console.WriteLine($"Material:                       {_dogLeash[name].Material}");
                    //Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine("\n                     * Dog Leash does not exist in database *                       \n");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                }
            }
            else if (typeof(T) == typeof(CatFood))
            {
                try
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Name:                           {_catFood[name].Name}");
                    Console.WriteLine($"Description:                    {_catFood[name].Description}");
                    Console.WriteLine($"Price:                          {_catFood[name].Price}");
                    Console.WriteLine($"Discounted Price:               {_catFood[name].Price.DiscountThisPrice()}");
                    Console.WriteLine($"Quantity:                       {_catFood[name].Quantity}");
                    Console.WriteLine($"Safe for Kittens:               {_catFood[name].KittenFood}");

                    Console.WriteLine("----------------------------------------------------------------------------------------");

                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine("\nCat Food doesn't exist in database.\n");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                }
            }
        }
        public void DisplayAllProducts()
        {
            foreach (var product in _dogLeash)
            {
                    DisplayProduct<DogLeash>(product.Key);
            }
            foreach (var product in _catFood)
            {
                DisplayProduct<CatFood>(product.Key);
            }
            foreach (var product in _dryCatFood)
            {
                try
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Name:                           {_dryCatFood[product.Key].Name}");
                    Console.WriteLine($"Description:                    {_dryCatFood[product.Key].Description}");
                    Console.WriteLine($"Price:                          {_dryCatFood[product.Key].Price}");
                    Console.WriteLine($"Discounted Price:               {_dryCatFood[product.Key].Price.DiscountThisPrice()}");
                    Console.WriteLine($"Quantity:                       {_dryCatFood[product.Key].Quantity}");
                    Console.WriteLine($"Safe For Kittens:               {_dryCatFood[product.Key].KittenFood}");
                    Console.WriteLine($"Weight:                         {_dryCatFood[product.Key].WeightPounds}");

                    Console.WriteLine("----------------------------------------------------------------------------------------");

                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine("\nCat Food doesn't exist in database.\n");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                }
            }
        }
        }
    }




