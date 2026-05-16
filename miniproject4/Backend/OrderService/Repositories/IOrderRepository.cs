using OrderService.Models;

namespace OrderService.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> CreateOrderAsync(Order order);
        Task<IEnumerable<Order>>
GetAllOrdersAsync();
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);

        Task<Order?> GetOrderByIdAsync(int orderId);
    }
}
