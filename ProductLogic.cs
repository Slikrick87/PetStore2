namespace PetStore
{
    public class ProductLogic
    {
        public List<Product> _products = new List<Product>();
        public Dictionary<string, DogLeash> _DogLeash = new Dictionary<string, DogLeash>();
        public Dictionary<string, CatFood> _CatFood = new Dictionary<string, CatFood>();

        public Product AddProduct(Product product)
        {
            _products.Add(product);

            if (product.GetType() == typeof(CatFood))
            {
                _CatFood.Add(product.Name, product as CatFood);
            }
            else if (product.GetType() == typeof(DogLeash))
            {
                _DogLeash.Add(product.Name, product as DogLeash);
            }
            return product;
        }
        public void GetAllProducts(List<Product> _products)
        {
            foreach (Product product in _products)
            {

                Console.WriteLine($"\nProduct Name:  " + product.Name);
                Console.WriteLine($"Description:     " + product.Description);
                Console.WriteLine($"Price:           " + product.Price);
                Console.WriteLine($"Quantity:        " + product.Quantity);
                //if (product.GetType() == typeof(CatFood)) 
                //{
                //    Console.WriteLine($"Weight:           " + product.WeightPounds);
                //}
            }
        }

        public Product GetDogLeashByName(string name)
        {
            return _DogLeash[name];
        }

    }
}


