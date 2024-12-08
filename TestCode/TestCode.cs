using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;              
using PetStore;
using PetStore.Logic;

namespace PetStore
{
    public class TestCode
    {
        public static void DogLeashRepo(DogLeashLogic TestRepositoryDogLeash)
        {
         
            
            DogLeash dogLeash1 = new DogLeash("Da Rizzler", 14.99m, 87, "BadAss", 12, "Leather");
            TestRepositoryDogLeash.AddDogLeash(dogLeash1);
            //_products.Add(dogLeash1);


            DogLeash dogLeash2 = new DogLeash("Lame AF", 9.99m, 20, "Pretty Lame", 6, "Some Lame Crap");
            TestRepositoryDogLeash.AddDogLeash(dogLeash2);
            //_products.Add(dogLeash2);

            DogLeash dogLeash3 = new DogLeash("The One Ring", 199.99m, 0, "Pretty Powerful", 6, "Powerful Magic");
            TestRepositoryDogLeash.AddDogLeash(dogLeash3);
            //_products.Add(dogLeash3);

        }
        public static void CatFoodRepo(CatFoodLogic TestRepositoryCatFood)
        {
            CatFood Meowzler = new CatFood("Meowzer", 29.99m, 0, "CharBroiled", true);
            TestRepositoryCatFood.AddCatFood(Meowzler);

            CatFood catFood1 = new CatFood("Pringles", 3.99m, 24, "Sour Cream and Onion", true);
            TestRepositoryCatFood.AddCatFood(catFood1);
            //_products.Add(catFood1);

            CatFood catFood2 = new CatFood("Kittie Chow", 19.99m, 24, "RoadKill", false);
            TestRepositoryCatFood.AddCatFood(catFood2);
            //_products.Add(catFood2);

            CatFood catFood3 = new CatFood("Spam", 5.99m, 72, "Shelf Stable!!", true);
            TestRepositoryCatFood.AddCatFood(catFood3);
            //_products.Add(catFood3);
        }
        public static void DryCatFoodRepo(CatFoodLogic TestRepositoryCatFood)
        {
            DryCatFood dryCatFood1 = new DryCatFood("Shrimp Meal", 9.99m, 16, "Wild Caught.", true, 5);
            
        }
    }
}


