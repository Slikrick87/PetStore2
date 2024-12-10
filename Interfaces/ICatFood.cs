using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore;
using PetStore.Logic;

namespace PetStore
{
    interface ICatFood : IProductLogic
    {
        public CatFood NewCatFood();
        public CatFood EditProductCatFood();
        public void GetCatFoodByName(string Name);
        public CatFood AddCatFood(CatFood catFood);
        public void DisplayAllCatFood(Dictionary<string, CatFood> _CatFood);
        public List<String> GetOutOfStockCatFood();
        public List<CatFood> GetOnlyInStockCatFood();
        public decimal GetCatFoodInventoryTotal();
        //public void CatFoodRepo(CatFoodLogic catFoodClass);
        //public List<T> InStockCatFood<T>();
    }
    ///Should I put Extensions in Interface?
}
