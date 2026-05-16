using OrderService.Data;
using OrderService.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderService.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return order;
        }

        public async Task<IEnumerable<Order>>
            GetOrdersByUserIdAsync(int userId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.UserId == userId)
                .ToListAsync();
        }

        public async Task<Order?> GetOrderByIdAsync(int orderId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.OrderId == orderId);
        }
        public async Task<IEnumerable<Order>>
GetAllOrdersAsync()
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .ToListAsync();
        }
    }
}
