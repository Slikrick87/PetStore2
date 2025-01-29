using PetStore.Data;
using PetStore.Logic;
using PetStore.Validators;
namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _IRepo;

        public Dictionary<String, DogLeash> _dogLeash = new(StringComparer.InvariantCultureIgnoreCase);
        //public Dictionary<String, CatFood> _catFood = new(StringComparer.InvariantCultureIgnoreCase);
        //public Dictionary<String, DryCatFood> _dryCatFood = new(StringComparer.InvariantCultureIgnoreCase);
        //public List<Product> _products = new();

        //public DogLeashValidator dogLeashValidator = new DogLeashValidator();
        //public CatFoodValidator catFoodValidator = new CatFoodValidator();
        public ProductValidator productValidator = new ProductValidator();
        public ProductLogic(IProductRepository Repo)
        {
        }
        //public void AddProduct(ProductEntity product)
        public void AddProductDb(ProductEntity product)
        {
            
            _IRepo.AddProduct(product);
        }
        public ProductEntity NewProduct()
        {
            string name;
            do
            {
                Console.WriteLine("Enter the name of the product: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            string price;
            decimal productPrice;
            do
            {
                Console.WriteLine("Enter the price of the product: ");
                price = Console.ReadLine();
            } while (!decimal.TryParse(price, out productPrice));
            string quantity;
            int productQuantity;
            do
            {
                Console.WriteLine("Enter the quantity of the product: ");
                quantity = Console.ReadLine();
            } while (!int.TryParse(quantity, out productQuantity));
            string description;
            do
            {
                Console.WriteLine("Enter the description of the product: ");
                description = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(description));
            //int id = _IRepo.GetNextProductId();
            ProductEntity product = new ProductEntity
            {
                //Id = id,
                Name = name,
                Price = productPrice,
                Quantity = productQuantity,
                Description = description
            };
            return product;
        }
        //public List<Product> GetAllProducts()
        //{
        //    return _products;
        //}
        //public List<Product> GetOnlyInStockProducts()
        //{
        //    return _products.InStock();
        //}
        //public decimal GetProductInventoryTotal()
        //{
        //    return _products.InStock().Select(p => p.Price * p.Quantity).Sum();
        //} //definitely wrong total price or my math is bad
        //public List<String> GetOutOfStockProducts()
        //{
        //    return _products.Where(p => p.Quantity == 0).Select(p => p.Name).ToList();
        //}
        //public T GetProductById<T>(int id) where T : Product
        //{
        //    if (typeof(T) == typeof(DogLeash))
        //    {
        //        return _IRepo.GetDogLeashById(id) as T;
        //    }
        //    else if (typeof(T) == typeof(CatFood))
        //    {
        //        return _IRepo.GetCatFoodById(id) as T;
        //    }
        //    return null;
        //}
        //public void DisplayProduct<T>(string name) where T : Product
        //{
        //    if (typeof(T) == typeof(DogLeash))
        //    {
        //        try
        //        {
        //            Console.WriteLine("----------------------------------------------------------------------------------------");
        //            Console.WriteLine($"Name:                           {_dogLeash[name].Name}");
        //            Console.WriteLine($"Description:                    {_dogLeash[name].Description}");
        //            Console.WriteLine($"Price:                          {_dogLeash[name].Price}");
        //            Console.WriteLine($"Discounted Price:               {_dogLeash[name].Price.DiscountThisPrice()}");
        //            Console.WriteLine($"Quantity:                       {_dogLeash[name].Quantity}");
        //            Console.WriteLine($"Length:                         {_dogLeash[name].LengthInches}\"");
        //            Console.WriteLine($"Material:                       {_dogLeash[name].Material}");
        //            //Console.WriteLine($"Description:                    {_DogLeash[name].Description}");
        //            Console.WriteLine("----------------------------------------------------------------------------------------");

        //        }
        //        catch (KeyNotFoundException e)
        //        {
        //            Console.WriteLine("\n                     * Dog Leash does not exist in database *                       \n");
        //            Console.WriteLine("----------------------------------------------------------------------------------------");
        //        }
        //    }
        //    else if (typeof(T) == typeof(CatFood))
        //    {
        //        try
        //        {
        //            Console.WriteLine("----------------------------------------------------------------------------------------");
        //            Console.WriteLine($"Name:                           {_catFood[name].Name}");
        //            Console.WriteLine($"Description:                    {_catFood[name].Description}");
        //            Console.WriteLine($"Price:                          {_catFood[name].Price}");
        //            Console.WriteLine($"Discounted Price:               {_catFood[name].Price.DiscountThisPrice()}");
        //            Console.WriteLine($"Quantity:                       {_catFood[name].Quantity}");
        //            Console.WriteLine($"Safe for Kittens:               {_catFood[name].KittenFood}");

        //            Console.WriteLine("----------------------------------------------------------------------------------------");

        //        }
        //        catch (KeyNotFoundException e)
        //        {
        //            Console.WriteLine("\nCat Food doesn't exist in database.\n");
        //            Console.WriteLine("----------------------------------------------------------------------------------------");
        //        }
        //    }
        //}
        //public void DisplayAllProducts()
        //{
        //    foreach (var product in _dogLeash)
        //    {
        //            DisplayProduct<DogLeash>(product.Key);
        //    }
        //    foreach (var product in _catFood)
        //    {
        //        DisplayProduct<CatFood>(product.Key);
        //    }
        //    foreach (var product in _dryCatFood)
        //    {
        //        try
        //        {
        //            Console.WriteLine("----------------------------------------------------------------------------------------");
        //            Console.WriteLine($"Name:                           {_dryCatFood[product.Key].Name}");
        //            Console.WriteLine($"Description:                    {_dryCatFood[product.Key].Description}");
        //            Console.WriteLine($"Price:                          {_dryCatFood[product.Key].Price}");
        //            Console.WriteLine($"Discounted Price:               {_dryCatFood[product.Key].Price.DiscountThisPrice()}");
        //            Console.WriteLine($"Quantity:                       {_dryCatFood[product.Key].Quantity}");
        //            Console.WriteLine($"Safe For Kittens:               {_dryCatFood[product.Key].KittenFood}");
        //            Console.WriteLine($"Weight:                         {_dryCatFood[product.Key].WeightPounds}");

        //            Console.WriteLine("----------------------------------------------------------------------------------------");

        //        }
        //        catch (KeyNotFoundException e)
        //        {
        //            Console.WriteLine("\nCat Food doesn't exist in database.\n");
        //            Console.WriteLine("----------------------------------------------------------------------------------------");
        //        }
        //    }
        //}
    }
    }




