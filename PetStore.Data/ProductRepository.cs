using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<OrderEntity> Orders { get; set; }
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public void AddProduct(ProductEntity product)
        {
            //if (product is CatFoodEntity catFood)
            //{
                _context.Products.Add(product);
            //}
            //else if (product is DogLeashEntity dogLeash)
            //{
            //    _context.DogLeashes.Add(dogLeash);
            //}
            //else
            //{
            //    _context.Products.Add(product);
            //}
            //_context.Products.Add(product);
            _context.SaveChanges();
        }
        public ProductEntity ProductById(int id)
        {
            var product = _context.Products.Find(id);
            try { return product; }
            catch { return null; }

        }
        //public DogLeashEntity GetDogLeashById(int id)
        //{
        //    var dogLeash = _context.DogLeashes.Find(id);
        //    try { return dogLeash; }
        //    catch { return null; }
        //}
        public void GetAllProducts()
        {
            var products = _context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
        }
        public int GetNumberOfProducts()
        {
            int count = _context.Products.Count();
            return count;
        }
        public int GetNextProductId()
        {
            return GetNumberOfProducts() + 1;
        }
    }
}
