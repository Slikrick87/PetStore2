//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PetStore.Data
//{
//    public class OrderRepository : IOrderRepository
//    {
//        private readonly OrderContext _context;
//        public DbSet<OrderEntity> Orders { get; set; }
//        public OrderRepository(OrderContext context)
//        {
//            _context = context;
//        }
//        public void AddOrder(OrderEntity order)
//        {
//            _context.Orders.Add(order);
//            _context.SaveChanges();
//        }
//        public OrderEntity GetOrderById(int id)
//        {
//            //var order = _context.Orders.Where(o => o.OrderId == id).Include(x=>x.Products);
//            //Orders.Include(x => x.Products);
//            try { return (OrderEntity)_context.Orders.Where(o => o.OrderId == id).Include(x => x.Products); }
//            catch { return null; }
//        }
//        public void GetAllOrders()
//        {
//            var orders = _context.Orders.ToList();
//            foreach (var order in orders)
//            {
//                Console.WriteLine($"Order ID: {order.OrderId}, Order Date: {order.OrderDate}");
//            }
//        }
//        public int GetNumberOfOrders()
//        {
//            int count = _context.Orders.Count();
//            return count;
//        }
//        public int GetNextOrderId()
//        {
//            return GetNumberOfOrders() + 1;
//        }
//        public void AddProductToOrder(int orderId, ProductEntity product)
//        {
//            var order = _context.Orders.Find(orderId);
//            if (order != null)
//            {
//                order.Products.Add(product);
//                _context.SaveChanges();
//            }
//        }
//    }
//}
