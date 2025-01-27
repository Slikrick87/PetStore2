namespace PetStore.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public void AddProduct<T>(T product)
        {
            if (product is CatFoodEntity catFood)
            {
                _context.CatFoods.Add(catFood);
            }
            else if (product is DogLeashEntity dogLeash)
            {
                _context.DogLeashes.Add(dogLeash);
            }
            //else
            //{
            //    _context.Products.Add(product);
            //}
            //_context.Products.Add(product);
            _context.SaveChanges();
        }
        public void GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                Console.WriteLine($"Product found: {product.Name}, Price: {product.Price}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
        public void GetAllProducts()
        {
            var products = _context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
