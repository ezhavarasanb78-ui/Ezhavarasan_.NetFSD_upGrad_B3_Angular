using System.ComponentModel.DataAnnotations;

namespace ProductService.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public int Stock { get; set; }
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
