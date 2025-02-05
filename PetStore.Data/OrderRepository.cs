//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _context;
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public OrderRepository(OrderContext context)
        {
            _context = context;
        }
        public OrderEntity NewOrder()
        {
            //int id = GetNextOrderId();
            DateTime date = DateTime.Now;
            OrderEntity order = new OrderEntity
            {
                //OrderId = id,
                OrderDate = date
            };
            AddOrder(order);
            return order;
        }
        public void AddOrder(OrderEntity order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public OrderEntity GetOrderById(int id)
        {
            var order = _context.Orders
                                .Include(o => o.Products)
                                .FirstOrDefault(o => o.OrderId == id);
            return order;
        }
        public void GetAllOrders()
        {
            var orders = _context.Orders.ToList();
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Order Date: {order.OrderDate}");
            }
        }
        public int GetNumberOfOrders()
        {
            int count = _context.Orders.Count();
            return count;
        }
        public int GetNextOrderId()
        {
            return GetNumberOfOrders() + 1;
        }
        public void AddProductToOrder(OrderEntity order, ProductEntity product)
        {
            //var order = GetOrderById(orderId);
            if (order != null)
            {
                order.Products.Add(product);
                _context.SaveChanges();
            }
        }
        public void DisplayProductsInOrder(OrderEntity order)
        {
            foreach (ProductEntity p in order.Products)
            {
                Console.WriteLine($"Product Name: " + p.Name);
            }
        }
    }
}
