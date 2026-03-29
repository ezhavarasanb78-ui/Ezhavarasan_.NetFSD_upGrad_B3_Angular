using System.ComponentModel.DataAnnotations;

namespace CRUDAPP.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Name must be 5 to 15 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public string Category { get; set; }
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Category must be 5 to 15 characters")]
        public decimal Price { get; set; }
    }
}
