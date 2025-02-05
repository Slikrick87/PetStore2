using Microsoft.EntityFrameworkCore;

namespace PetStore.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public ProductRepository(ProductContext context)
        {
            _context = context;
        }
        public void AddProductDb(ProductEntity product)
        {
                _context.Products.Add(product);
            
            _context.SaveChanges();
        }
        public ProductEntity ProductById(int id)
        {
            var product = _context.Products.Find(id);
            try { return product; }
            catch { return null; }

        }
        
        public void GetAllProducts()
        {
            var products = _context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}, ID: {product.Id}");
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
        //public void OrderRepository(OrderContext context)
        //{
        //    _context = context;
        //}
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
        //public OrderEntity GetOrderById(int id)
        //{
        //    //var order = _context.Orders.Where(o => o.OrderId == id).Include(x=>x.Products);
        //    //Orders.Include(x => x.Products);
        //    if (_context.Orders.Where(o => o.OrderId == id).Include(x => x.Products) == null)
        //    {
public OrderEntity GetOrderById(int id)
        {
            var order = _context.Orders
                                .Include(o => o.Products)
                                .FirstOrDefault(o => o.OrderId == id);
            return order;
        }
    //}
        //    else if
        //        {

        //    }
        //    else
        //    {
        //        return (OrderEntity)_context.Orders.Where(o => o.OrderId == id)/*.Include(x => x.Products)*/; }
            
        //}
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
