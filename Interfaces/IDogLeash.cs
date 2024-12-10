using PetStore.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal interface IDogLeash : IProductLogic //IDictionary<string, DogLeash>
    {
        public DogLeash NewDogLeash();
        public void GetProductByName(string name);
        public DogLeash EditProductDogLeash();
        public DogLeash AddDogLeash(DogLeash dogLeash);
        public void DisplayAllDogLeash(Dictionary<string, DogLeash> _DogLeash);
        //public Dictionary<string, DogLeash> GetOnlyInStockDogLeashes();
        //public decimal DiscountThisPrice(this decimal lylaPrice);
        public List<String> GetOutOfStockDogLeashes(); //not the way assignment said to do it couldn't get it to work their way
        public List<DogLeash> GetOnlyInStockDogLeashes();
        //public List<T> InStockDogLeashes<T>();
        public decimal GetDogLeashInventoryTotal();
        public void GetDogLeashByName(string name);
        //public void DogLeashRepo(DogLeashLogic dogLeashLogic);
    }
   ///Should I put Extensions in Interface?
}
