using Moq;using PetStore;
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
            Mock<IProductRepository> _productRepositoryMock = new Mock<IProductRepository>();
            Mock<IOrderRepository> _orderRepositoryMock = new Mock<IOrderRepository>();
            ProductLogic _productLogic = new ProductLogic(_productRepositoryMock.Object, _orderRepositoryMock.Object);
            _productRepositoryMock.Setup(x => x.GetProductById(10))
    .Returns(new ProductEntity("Test Object", 9.99M, 5, "Make Believe"));
            // Act
    //        _productRepositoryMock.Setup(x => x.GetProductById(10))
    //.Returns(new ProductEntity("Test Object", 9.99M, 5, "Make Believe"));
            ProductEntity product = _productRepositoryMock.Object.GetProductById(10);

            //Assert
            _productRepositoryMock.Verify(x => x.GetProductById(10), Times.Once);
        }
    }
}
