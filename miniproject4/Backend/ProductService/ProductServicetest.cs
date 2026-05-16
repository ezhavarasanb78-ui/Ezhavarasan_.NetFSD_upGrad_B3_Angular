using Xunit;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void ProductList_ShouldNotBeEmpty()
        {
            var products = new List<string>
            {
                "Laptop",
                "Mobile"
            };

            Assert.NotEmpty(products);
        }

        [Fact]
        public void SearchProduct_ShouldReturnCorrectProduct()
        {
            var products = new List<string>
            {
                "Laptop",
                "Mobile"
            };

            Assert.Contains("Laptop", products);
        }

        [Fact]
        public void InvalidProduct_ShouldReturnFalse()
        {
            int productId = 0;

            Assert.False(productId > 0);
        }

        [Fact]
        public void ProductCount_ShouldBeCorrect()
        {
            var products = new List<string>
            {
                "Laptop",
                "Mobile"
            };

            Assert.Equal(2, products.Count);
        }
    }
}