namespace PetStore
{
    public class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; } // should i use a ? or =string.empty
    }

    //public class CatFood : Product
    //{
    //    public double WeightPounds { get; set; }
    //    public bool KittenFood { get; set; }
    //}

    //public class DogLeash : Product
    //{
    //    public int LengthInches { get; set; }
    //    public string? Material { get; set; }
    //}
}
