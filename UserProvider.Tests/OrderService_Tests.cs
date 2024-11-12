using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProvider.Business.Models;
using UserProvider.Business.Services;

namespace UserProvider.Tests
{
    public class OrderServiceTests
    {
        //Skrivet med hjälp av chatgpt
        [Fact]
        public void GetOrderHistory_ReturnsListOfOrdersWithBasicInformation()
        {
            // Arrange
            var orderRepositoryMock = new Mock<IOrderRepository>();
            var expectedOrders = new List<Order>
            {
                new Order { OrderNumber = "1001", OrderDate = DateTime.Now.AddDays(-10), Status = "Delivered", TotalAmount = 199.99m },
                new Order { OrderNumber = "1002", OrderDate = DateTime.Now.AddDays(-5), Status = "Shipped", TotalAmount = 49.99m }
            };

            orderRepositoryMock.Setup(x => x.GetOrderHistory()).Returns(expectedOrders);

            var orderService = new OrderService(orderRepositoryMock.Object);

            // Act
            var result = orderService.GetOrderHistory();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("1001", result[0].OrderNumber);
            Assert.Equal("Delivered", result[0].Status);
            Assert.Equal(199.99m, result[0].TotalAmount);
            Assert.Equal("1002", result[1].OrderNumber);
            Assert.Equal("Shipped", result[1].Status);
            Assert.Equal(49.99m, result[1].TotalAmount);
        }
    }
}
