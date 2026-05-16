using ProductService.DTOs;
using ProductService.Models;
using ProductService.Repositories;

namespace ProductService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync()
        {
            var products = await _repo.GetAllAsync();

            return products.Select(p => new ProductResponseDTO
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                ImageUrl = p.ImageUrl,
                Stock = p.Stock,
                CategoryId = p.CategoryId
            });
        }

        public async Task<Product> CreateProductAsync(ProductDTO dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                ImageUrl = dto.ImageUrl,
                Stock = dto.Stock,
                CategoryId = dto.CategoryId
            };

            return await _repo.AddAsync(product);
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null) throw new Exception("Not found");
            return product;
        }

        public async Task<ProductResponseDTO> UpdateProductAsync( int id,ProductDTO dto)
        {
            var product = await _repo.GetByIdAsync(id);
            if (product == null)
                throw new Exception("Not found");

            product.Name = dto.Name;
            product.Description = dto.Description;
            product.Price = dto.Price;
            product.ImageUrl = dto.ImageUrl;
            product.Stock = dto.Stock;
            product.CategoryId = dto.CategoryId;

            var updatedProduct =
                await _repo.UpdateAsync(product);

            return new ProductResponseDTO
            {
                ProductId = updatedProduct.ProductId,
                Name = updatedProduct.Name,
                Description = updatedProduct.Description,
                Price = updatedProduct.Price,
                ImageUrl = updatedProduct.ImageUrl,
                Stock = updatedProduct.Stock,
                CategoryId = updatedProduct.CategoryId
            };
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            return await _repo.DeleteAsync(id);
        }
    }
}