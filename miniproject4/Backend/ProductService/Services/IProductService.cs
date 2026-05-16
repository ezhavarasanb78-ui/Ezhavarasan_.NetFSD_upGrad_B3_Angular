using ProductService.Models;
using ProductService.DTOs;
namespace ProductService.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> CreateProductAsync(ProductDTO dto);
        Task<ProductResponseDTO> UpdateProductAsync
            (int id, ProductDTO dto);
        Task<bool> DeleteProductAsync(int id);
    }
}
