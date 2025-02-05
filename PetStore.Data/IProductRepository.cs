using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public interface IProductRepository
    {
        public DbSet<ProductEntity> Products { get; set; }
        //public DbSet<OrderEntity> Orders { get; set; }
        //public void AddProduct(ProductEntity product);
        public ProductEntity ProductById(int id);
        public void GetAllProducts();
        public int GetNumberOfProducts();
        public int GetNextProductId();
        public void AddProductDb(ProductEntity product);
        public void AddOrder(OrderEntity order);
        public OrderEntity GetOrderById(int id);
        public void AddProductToOrder(OrderEntity order, ProductEntity product);
        public void GetAllOrders();
        public OrderEntity NewOrder();
        public void DisplayProductsInOrder(OrderEntity order);

    }
}