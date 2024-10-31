using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public void PrintCatFood()
        {
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Product Name:    " + this.Name);
                Console.WriteLine($"Description:     " + this.Description);
                Console.WriteLine($"Price:           " + this.Price);
                Console.WriteLine($"Quantity:        " + this.Quantity);
                Console.WriteLine($"Weight:          " + this.WeightPounds + " lbs");
                Console.WriteLine($"Safe for Kittens:" + this.KittenFood);
                Console.WriteLine("------------------------------------------");
            }

        }
    }
}
