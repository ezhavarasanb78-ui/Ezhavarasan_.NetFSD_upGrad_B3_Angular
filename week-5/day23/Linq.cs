using System;
using System.Collections.Generic;
using System.Text;

namespace day23
{
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Mrp { get; set; }
    }
    internal class Linq
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                  new Product { Code = 1, Name = "Soap", Category = "FMCG", Mrp = 25 },
                  new Product { Code = 2, Name = "Rice", Category = "Grain", Mrp = 50 },
                  new Product { Code = 3, Name = "Oil", Category = "FMCG", Mrp = 120 },
                  new Product { Code = 4, Name = "Wheat", Category = "Grain", Mrp = 40 },
                  new Product { Code = 5, Name = "Shampoo", Category = "FMCG", Mrp = 30 }
             };

            var fmcg = products.Where(p => p.Category == "FMCG");
            Console.WriteLine(fmcg);

            foreach(var i in fmcg)
            {
                Console.WriteLine($"{i.Name}");
            }
            var grain = products.Where(c => c.Category == "Grain");
            foreach (var i in grain)
            {
                Console.WriteLine($"{i.Name}");
            }
            var s = products.OrderBy(p => p.Name);
            foreach (var i in s)
            {
                Console.WriteLine($"{i.Name}");
            }
            var c = products.OrderBy(p => p.Code);
            foreach (var i in c)
            {
                Console.WriteLine($"{i.Code}");
            }
            var d = products.OrderBy(p => p.Mrp);
            var e = products.OrderByDescending(p => p.Mrp);
            var g = products.GroupBy(p => p.Category);
            foreach(var i in g)
            {
                Console.WriteLine($"{i.Key}");
                foreach(var j in i)
                {
                    Console.WriteLine(j.Name);
                }
            }
            var h = products.GroupBy(p => p.Mrp);
            var maxFmcg = products
.           Where(p => p.Category == "FMCG")
.           OrderByDescending(p => p.Mrp)
.           FirstOrDefault();
            var tot = products.Count();
            var fmcgcount = products.Count(p => p.Category == "FMCG");
            var mx = products.Max(p => p.Mrp);
            var mi = products.Min(p => p.Mrp);
            var k = products.All(p => p.Mrp>30);
            var l = products.All(p => p.Mrp < 30);
        }
    }
}
