using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;
using PetStore.Logic;

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
            .BuildServiceProvider();

        }
        public static IServiceProvider CreateDogLeashServiceCollection()
        {
            return new ServiceCollection()
            .AddTransient<IDogLeash, DogLeashLogic>()
            .BuildServiceProvider();

        }
        public static IServiceProvider CreateCatFoodServiceCollection()
        {
            return new ServiceCollection()
            .AddTransient<ICatFood, CatFoodLogic>()
            .BuildServiceProvider();

        }
    }
}
