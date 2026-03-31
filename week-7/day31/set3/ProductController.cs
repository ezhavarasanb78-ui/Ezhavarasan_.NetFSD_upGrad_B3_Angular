using Microsoft.AspNetCore.Mvc;
namespace Day31.Controllers
{
    public class ProductController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = GetProducts();
            ViewBag.Products = products;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string name,double price,int quantity)
        {
            var Products = GetProducts();
            Products.Add(new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity
            });
            List<string> data = new List<string>();
            foreach (var item in Products)
            {
                data.Add($"{item.Name},{item.Price},{item.Quantity}");
            }

            HttpContext.Session.SetString("ProductList", string.Join("|", data));

            return RedirectToAction("Index");
        }
        private List<Product> GetProducts()
        {
            var productList = new List<Product>();

            var data = HttpContext.Session.GetString("ProductList");

            if (!string.IsNullOrEmpty(data))
            {
                var items = data.Split("|");

                foreach (var item in items)
                {
                    var values = item.Split(",");

                    productList.Add(new Product
                    {
                        Name = values[0],
                        Price = double.Parse(values[1]),
                        Quantity = int.Parse(values[2])
                    });
                }
            }

            return productList;
        }
    }
    public class Product()
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
