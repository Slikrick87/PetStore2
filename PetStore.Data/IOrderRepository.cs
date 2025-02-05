namespace PetStore.Data
{
    public interface IOrderRepository
    {
        void AddOrder(OrderEntity order);
        OrderEntity GetOrderById(int id);
        void GetAllOrders();
        int GetNumberOfOrders();
        int GetNextOrderId();
        void AddProductToOrder(int orderId, ProductEntity product);
    }
}