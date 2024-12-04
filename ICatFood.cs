using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;

namespace PetStore
{
    interface ICatFood
    {
        public CatFood NewCatFood();
        public CatFood EditProductCatFood();
        public void GetCatFoodByName(string Name);
        public CatFood AddCatFood(CatFood catFood);
        public void DisplayAllCatFood(Dictionary<string, CatFood> _CatFood);
        public List<String> GetOutOfStockCatFood();
        public List<CatFood> GetOnlyInStockCatFood();
        //public List<T> InStockCatFood<T>();
    }
    ///Should I put Extensions in Interface?
}
