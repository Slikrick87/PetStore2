namespace PetStore.Data
{
    public interface IProductRepository
    {
        public void AddProduct<T>(T product);
        public void GetProductById(int id);
        public void GetAllProducts();
    }
}