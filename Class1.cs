using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;
        public string Description;
    }

    public class CatFood:Product
    {
        public double WeightPounds;
        public bool KittenFood;
    }

    public class DogLeash:Product
    {
        public int LengthInches;
        public string Material;
    }
}
