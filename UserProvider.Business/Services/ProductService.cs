using UserProvider.Business.Models;

namespace UserProvider.Business.Services;

public class ProductService
{
    private List<Product> _productWishlist = new List<Product>();

    public void AddProductToWishlist(Product product)
    {
        _productWishlist.Add(product);
    }

    public List<Product> GetWishlist()
    {
        return _productWishlist;
    }
}
