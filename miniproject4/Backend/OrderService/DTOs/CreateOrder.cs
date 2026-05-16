namespace OrderService.DTOs
{
    public class CreateOrder
    {
        public int UserId { get; set; }

        public List<CreateOrderItem> Items { get; set; }
            = new List<CreateOrderItem>();
    }
}
