using Microsoft.Extensions.DependencyInjection;
using PetStore.Logic;
using PetStore.Data;

namespace PetStore
{
    public class ServiceDependencyProvider
    {
        public static IServiceProvider CreateProductServiceCollection()
        {
            return new ServiceCollection()
            .AddTransient<IProductLogic, ProductLogic>()
            .AddTransient<IDogLeash, DogLeashLogic>()
            .AddTransient<ICatFood, CatFoodLogic>()
            .AddTransient<IProductRepository, ProductRepository>()
            .BuildServiceProvider();

        }
    }
}
