using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class DogLeashEntity : ProductEntity
    {
        public int LengthInches { get; set; }
        public string? Material { get; set; }
    }
}
