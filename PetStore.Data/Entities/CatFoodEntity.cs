using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class CatFoodEntity : ProductEntity
    {
        public bool KittenFood { get; set; }

        public CatFoodEntity(int id, string name, decimal price, int quantity, string description, bool kittenFood)
        {
            this.KittenFood = kittenFood;
        }
    }
}
