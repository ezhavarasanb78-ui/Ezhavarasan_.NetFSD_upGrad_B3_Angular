using OrderService.DTOs;
using OrderService.Models;

namespace OrderService.Services
{
    public interface IOrderService
    {
        Task<OrderResponse> CreateOrderAsync(CreateOrder dto);

        Task<IEnumerable<Order>> GetOrdersAsync(int userId);

        Task<Order?> GetOrderByIdAsync(int orderId);
        Task<IEnumerable<Order>>
GetAllOrdersAsync();
    }
}
