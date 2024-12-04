using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal interface IDogLeash
    {
        public DogLeash NewDogLeash();
        public void GetDogLeashByName(string name);
        public DogLeash EditProductDogLeash();
        public DogLeash AddDogLeash(DogLeash dogLeash);
        public void DisplayAllDogLeash(Dictionary<string, DogLeash> _DogLeash);
        //public Dictionary<string, DogLeash> GetOnlyInStockDogLeashes();
        public List<String> GetOutOfStockDogLeashes(); //not the way assignment said to do it couldn't get it to work their way
        public List<DogLeash> GetOnlyInStockDogLeashes();
        //public List<T> InStockDogLeashes<T>();
        public decimal GetDogLeashInventoryTotal();
    }
   ///Should I put Extensions in Interface?
}
