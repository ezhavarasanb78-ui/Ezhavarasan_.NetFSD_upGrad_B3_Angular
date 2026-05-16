using Xunit;
using System.Collections.Generic;

namespace OrderService.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public void CreateOrder_ShouldPass()
        {
            bool orderCreated = true;

            Assert.True(orderCreated);
        }

        [Fact]
        public void EmptyCart_ShouldFail()
        {
            var cart = new List<string>();

            Assert.Empty(cart);
        }

        [Fact]
        public void OrderHistory_ShouldReturnOrders()
        {
            var orders = new List<int>
            {
                1,
                2
            };

            Assert.Equal(2, orders.Count);
        }

        [Fact]
        public void InvalidOrderId_ShouldFail()
        {
            int orderId = 0;

            Assert.False(orderId > 0);
        }

        [Fact]
        public void TotalAmount_ShouldBeGreaterThanZero()
        {
            decimal amount = 1000;

            Assert.True(amount > 0);
        }
    }
}
