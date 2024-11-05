using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;              
using PetStore;

namespace PetStore
{
    public class TestCode
    {
        public static void DogLeashRepo(DogLeashLogic TestRepositoryDogLeash)
        {
            DogLeash dogLeash1 = new DogLeash();
            dogLeash1.Name = "Da Rizzler";
            dogLeash1.Price = 14.99m;
            dogLeash1.Quantity = 87;
            dogLeash1.Description = "BadAss";
            dogLeash1.LengthInches = 12;
            dogLeash1.Material = "Leather";
            TestRepositoryDogLeash.AddDogLeash(dogLeash1);
            //_products.Add(dogLeash1);


            DogLeash dogLeash2 = new();
            dogLeash2.Name = "Lame AF";
            dogLeash2.Price = 9.99m;
            dogLeash2.Quantity = 20;
            dogLeash2.Description = "Pretty Lame";
            dogLeash2.LengthInches = 6;
            dogLeash2.Material = "Some Lame Crap";
            TestRepositoryDogLeash.AddDogLeash(dogLeash2);
            //_products.Add(dogLeash2);

            DogLeash dogLeash3 = new();
            dogLeash3.Name = "The One Ring";
            dogLeash3.Price = 199.99m;
            dogLeash3.Quantity = 20;
            dogLeash3.Description = "Pretty Powerful";
            dogLeash3.LengthInches = 6;
            dogLeash3.Material = "Powerful Magic";
            TestRepositoryDogLeash.AddDogLeash(dogLeash3);
            //_products.Add(dogLeash3);

        }
        public static void CatFoodRepo(CatFoodLogic TestRepositoryCatFood)
        {
            CatFood catFood1 = new();
            catFood1.Name = "Pringles";
            catFood1.Price = 3.99m;
            catFood1.Quantity = 24;
            catFood1.Description = "Sour Cream and Onion";
            catFood1.WeightPounds = 1;
            catFood1.KittenFood = true;
            TestRepositoryCatFood.AddCatFood(catFood1);
            //_products.Add(catFood1);

            CatFood catFood2 = new();
            catFood2.Name = "Kittie Chow";
            catFood2.Price = 19.99m;
            catFood2.Quantity = 24;
            catFood2.Description = "RoadKill";
            catFood2.WeightPounds = 100;
            catFood2.KittenFood = false;
            TestRepositoryCatFood.AddCatFood(catFood2);
            //_products.Add(catFood2);

            CatFood catFood3 = new();
            catFood3.Name = "Spam";
            catFood3.Price = 5.99m;
            catFood3.Quantity = 72;
            catFood3.Description = "Shelf Stable!!";
            catFood3.WeightPounds = 3;
            catFood3.KittenFood = true;
            TestRepositoryCatFood.AddCatFood(catFood3);
            //_products.Add(catFood3);
        }
    }
}


