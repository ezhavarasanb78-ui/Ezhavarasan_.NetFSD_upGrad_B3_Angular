using Microsoft.AspNetCore.Mvc;
using ProductService.DTOs;
using ProductService.Services;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var product = await _service.GetProductByIdAsync(id);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await _service.CreateProductAsync(dto);

            return Ok(product);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductDTO dto)
        {
            try
            {
                var product = await _service.UpdateProductAsync(id, dto);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.DeleteProductAsync(id);

                return Ok(new
                {
                    message = "Product deleted successfully"
                });
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}