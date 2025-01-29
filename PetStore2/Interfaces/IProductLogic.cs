using PetStore.Data;
using PetStore.Logic;

namespace PetStore
{
    public interface IProductLogic
    {
        //public void DisplayProduct<T>(string name) where T : Product;
        //public void DisplayAllProducts();
        //public decimal GetProductInventoryTotal();
        //public List<Product> GetOnlyInStockProducts();
        //public List<String> GetOutOfStockProducts();
        public void AddProductDb(ProductEntity product);
        public ProductEntity NewProduct();
    }
}