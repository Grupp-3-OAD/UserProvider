using UserProvider.Business.Models;
using UserProvider.Business.Services;

namespace UserProvider.Tests;

public class ProductService_Tests
{
    //Skrivet med hjälp av Chatgtp
    [Fact]
    public void AddProductToWishlist_ShouldAddProductToList()
    {
        // Arrange
        var productService = new ProductService();
        var product = new Product { ProductId = 1, ProductName = "Spaghetti Pasta", Price = "24.95" };
            
        // Act
        productService.AddProductToWishlist(product);

        // Assert
        var products = productService.GetWishlist();
        Assert.Single(products);                     
        Assert.Equal(product, products[0]);         
    }
}
