using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public DbSet<ProductEntity> Products { get; set; }
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
        public CatFoodEntity GetCatFoodById(int id)
        {
            var catFood = _context.CatFoods.Find(id);
            try { return catFood; }
            catch { return null; }

        }
        public DogLeashEntity GetDogLeashById(int id)
        {
            var dogLeash = _context.DogLeashes.Find(id);
            try { return dogLeash; }
            catch { return null; }
        }
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
            return _context.DogLeashes.Count() + _context.CatFoods.Count();
        }
        public int GetNextProductId()
        {
            return GetNumberOfProducts() + 1;
        }
    }
}
