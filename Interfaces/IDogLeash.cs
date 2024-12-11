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
        //public void GetProductByName(string name);
        public DogLeash EditProductDogLeash();
        public DogLeash AddDogLeash(DogLeash dogLeash);
        //public void GetDogLeashByName(string name);
        public DogLeash CreateNewDogLeashJson();
        //public void DogLeashRepo(DogLeashLogic dogLeashLogic);
    }
   ///Should I put Extensions in Interface?
}
