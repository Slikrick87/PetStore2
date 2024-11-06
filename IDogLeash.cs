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
        public Dictionary<string, DogLeash> GetOnlyInStockDogLeashes();
        public /*List<DogLeash>*/ void GetOutOfStockDogLeashes(); //not the way assignment said to do it couldn't get it to work their way
    }
   
}
