using UserProvider.Business.Models;

namespace UserProvider.Tests
{
    public interface IOrderRepository
    {
        List<Order> GetOrderHistory();
    }
}