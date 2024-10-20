using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }

    public class CatFood:Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }

    public class DogLeash:Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }
    }
}
