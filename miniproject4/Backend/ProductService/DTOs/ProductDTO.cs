using System.ComponentModel.DataAnnotations;

namespace ProductService.DTOs
{
    public class ProductDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public int Stock { get; set; }

        public int CategoryId { get; set; }
    }
}
