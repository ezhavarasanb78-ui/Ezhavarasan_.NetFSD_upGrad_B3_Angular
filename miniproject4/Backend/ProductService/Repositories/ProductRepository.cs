using Microsoft.EntityFrameworkCore;
using ProductService.Dapper;
using ProductService.Data;
using ProductService.Models;
using Dapper;

namespace ProductService.Repositories
{
    public class ProductRepository:IProductRepository
    {
           private readonly AppDbContext _context;

        private readonly DapperContext _dapper;

        public ProductRepository(
            AppDbContext context,
            DapperContext dapper)
        {
            _context = context;
            _dapper = dapper;
        }

        public async Task<IEnumerable<Product>>
            GetAllAsync()
        {
            return await _context.Products
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<Product?>
            GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync
                (p => p.ProductId == id);
        }

        public async Task<Product>
            AddAsync(Product product)
        {
            await _context.Products
                .AddAsync(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product>
            UpdateAsync(Product product)
        {
            _context.Products.Update(product);

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<bool>
            DeleteAsync(int id)
        {
            var product =
                await _context.Products
                .FindAsync(id);

            if (product == null)
            {
                return false;
            }

            _context.Products.Remove(product);

            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<IEnumerable<Product>>
            SearchProductsAsync(string keyword)
        {
            using var connection =
                _dapper.CreateConnection();

            string query = @"
                SELECT *
                FROM Products
                WHERE Name LIKE @Keyword";

            var products =
                await connection.QueryAsync<Product>
                (
                    query,
                    new
                    {
                        Keyword =
                        $"%{keyword}%"
                    }
                );

            return products;
        }
    }
}
