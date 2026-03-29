using Microsoft.AspNetCore.Mvc;
using CRUDAPP.Models;
using System.Collections.Generic;
using System.Linq;
namespace CRUDAPP.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product>  prod=new List<Product>()
        {
           new Product { Id = 1, Name = "Laptop", Price = 50000, Category = "Electronics" },
           new Product { Id = 2, Name = "Mobile", Price = 20000, Category = "Electronics" }
        };
        public IActionResult Index()
        {
            return View(prod);
        }
        public IActionResult Details(int id)
        {
            var product = prod.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if(ModelState.IsValid)
            {
                prod.Add(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public IActionResult Edit(int id)
        {
            var product = prod.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            if(ModelState.IsValid)
            {
                var product = prod.FirstOrDefault(x => x.Id == p.Id);
                product.Name = p.Name;
                product.Price = p.Price;
                product.Category = p.Category;
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public IActionResult Delete(int id)
        {
            var product = prod.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult Deleteconfirmed(int id)
        {
            var product = prod.FirstOrDefault(x => x.Id == id);
            prod.Remove(product);
            return RedirectToAction("Index");
        }
    }
}
