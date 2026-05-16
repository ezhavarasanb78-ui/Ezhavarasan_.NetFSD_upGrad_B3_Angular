using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderService.DTOs;
using OrderService.Models;
using OrderService.Services;
using OrderService.Data;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController:ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrder dto)
        {
            var result =await _service.CreateOrderAsync(dto);

            return Ok(result);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult>GetOrders(int userId)
        {
            var orders =await _service.GetOrdersAsync(userId);

            return Ok(orders);
        }

        [HttpGet("{orderId}")]
        public async Task<IActionResult>GetOrderById(int orderId)
        {
            var order =await _service.GetOrderByIdAsync(orderId);
            return Ok(order);
        }
        [HttpGet]
        public async Task<IActionResult>
GetAllOrders()
        {
            var orders =
                await _service
                .GetAllOrdersAsync();

            return Ok(orders);
        }
    }
}
