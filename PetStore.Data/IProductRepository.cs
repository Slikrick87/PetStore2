using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public interface IProductRepository
    {
        public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<OrderEntity> Orders { get; set; }
        public void AddProduct(ProductEntity product);
        public ProductEntity ProductById(int id);
        public void GetAllProducts();
        public int GetNumberOfProducts();
        public int GetNextProductId();
    }
}