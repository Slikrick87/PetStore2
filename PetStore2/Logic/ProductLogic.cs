using PetStore.Data;
using PetStore.Logic;
using PetStore.Validators;
namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _IproductRepo;
        private readonly IOrderRepository _IOrderproductRepo;

        //public Dictionary<String, DogLeash> _dogLeash = new(StringComparer.InvariantCultureIgnoreCase);

        public ProductValidator productValidator = new ProductValidator();
        public ProductLogic(IProductRepository productRepo, IOrderRepository orderRepo)
        {
            _IproductRepo = productRepo;
            _IOrderproductRepo = orderRepo;
                //or create third repo to inherit from both
        }
        //public void AddProduct(ProductEntity product)
        public void AddProductDb(ProductEntity product)
        {
            
            _IproductRepo.AddProductDb(product);
        }
        public ProductEntity NewProduct()
        {
            int id;
            id = _IproductRepo.GetNextProductId();

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
            //int id = _IproductRepo.GetNextProductId();
           // int orderId = _IOrderproductRepo.GetNextOrderId();
            ProductEntity product = new ProductEntity
            (name, productPrice, productQuantity, description);
            return product;
        }
    }
    }




