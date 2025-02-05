using Moq;
using PetStore;
using PetStore.Data;
using System.Security.Cryptography.X509Certificates;

namespace ProductLogicTests
{
    [TestClass]
    public sealed class ProductLogicTests
    {
        [TestMethod]
        public void GetProductById_CallsproductRepo()
        {
            //Arrange
            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            Mock<IOrderRepository> orderRepository = new Mock<IOrderRepository>();
            // Act

            //Assert
        }
    }
}
