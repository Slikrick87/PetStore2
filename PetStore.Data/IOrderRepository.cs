using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public interface IOrderRepository
    {
        public OrderEntity NewOrder();
        public DbSet<OrderEntity> Orders { get; set;  }
        public DbSet<ProductEntity> Products { get; set; }
        void AddOrder(OrderEntity order);
        OrderEntity GetOrderById(int id);
        void GetAllOrders();
        int GetNumberOfOrders();
        int GetNextOrderId();
        void AddProductToOrder(OrderEntity orderEntity, ProductEntity product);
        public void DisplayProductsInOrder(OrderEntity order);
    }
}