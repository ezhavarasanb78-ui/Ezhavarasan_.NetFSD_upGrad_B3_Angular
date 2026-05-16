using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Pending";

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
