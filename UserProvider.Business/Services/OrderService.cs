using UserProvider.Business.Models;
using UserProvider.Tests;

namespace UserProvider.Business.Services;

public  class OrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public List<Order> GetOrderHistory()
    {
        return _orderRepository.GetOrderHistory();
    }
}
