using OrderService.DTOs;
using OrderService.Models;
using OrderService.Repositories;

namespace OrderService.Services
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public async Task<OrderResponse>
            CreateOrderAsync(CreateOrder dto)
        {
            if (dto.Items == null || !dto.Items.Any())
            {
                throw new Exception("Cart is empty");
            }

            var order = new Order
            {
                UserId = dto.UserId,
                TotalAmount =
                    dto.Items.Sum(i => i.Price * i.Quantity),
                Status = "Placed",
                OrderItems = dto.Items.Select(i =>
                    new OrderItem
                    {
                        ProductId = i.ProductId,
                        Quantity = i.Quantity,
                        Price = i.Price
                    }).ToList()
            };

            var result =
                await _repo.CreateOrderAsync(order);

            return new OrderResponse
            {
                OrderId = result.OrderId,
                UserId = result.UserId,
                TotalAmount = result.TotalAmount,
                Status = result.Status
            };
        }

        public async Task<IEnumerable<Order>>
            GetOrdersAsync(int userId)
        {
            return await _repo
                .GetOrdersByUserIdAsync(userId);
        }

        public async Task<Order?>
            GetOrderByIdAsync(int orderId)
        {
            return await _repo
                .GetOrderByIdAsync(orderId);
        }
        public async Task<IEnumerable<Order>>
GetAllOrdersAsync()
        {
            return await
                _repo.GetAllOrdersAsync();
        }
    }
}
