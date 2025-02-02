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

            services.AddDbContext<ProductContext>(options =>
                options.UseSqlite());

            services.AddTransient<IProductLogic, ProductLogic>()
            //.AddTransient<IDogLeash, DogLeashLogic>()
            //.AddTransient<ICatFood, CatFoodLogic>()
            .AddTransient<IProductRepository, ProductRepository>()
            .BuildServiceProvider();

            return services.BuildServiceProvider();
        }
    }
}
