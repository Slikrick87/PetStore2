namespace PetStore.Data
{
    public interface IProductRepository
    {
        public void AddProduct<T>(T product);
        public CatFoodEntity GetCatFoodById(int id);
        public DogLeashEntity GetDogLeashById(int id);
        public void GetAllProducts();
        public int GetNumberOfProducts();
        public int GetNextProductId();
    }
}