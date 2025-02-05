using Microsoft.Extensions.DependencyInjection;
using PetStore.Logic;
using PetStore.Data;
using Microsoft.EntityFrameworkCore;

namespace PetStore
{
    public class ServiceDependencyProvider
    {
        public static IServiceProvider CreateProductServiceCollection()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ProductContext>();
            services.AddDbContext<OrderContext>();

            services.AddTransient<IProductLogic, ProductLogic>()
            //.AddTransient<IDogLeash, DogLeashLogic>()
            //.AddTransient<ICatFood, CatFoodLogic>()
            .AddTransient<IProductRepository, ProductRepository>()
            .AddTransient<IOrderRepository, OrderRepository>()
            .BuildServiceProvider();

            return services.BuildServiceProvider();
        }
    }
}
