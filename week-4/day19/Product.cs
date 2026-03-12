using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Details
    {
        private int productId;
        private string productname;
        private double unitprice;
        private int qty;

        public Details(int id)
        {
            productId = id;
        }
        public int getId()
        {
            return productId;

        }
        public void setName(string name)
        {
            productname = name;

        }
        public string getName()
        {
            return productname;
        }
        public void setprice(double price)
        {
            unitprice = price;
        }
        public double getprice()
        {
            return unitprice;
        }
        public void setQuantity(int q)
        {
            qty = q;
        }
        public int getQuantity()
        {
            return qty;
        }
        public void show()
        {
            double tot = unitprice * qty;
            Console.WriteLine("ID " + productId);
            Console.WriteLine("name " + productname);
            Console.WriteLine("unit price " + unitprice);
            Console.WriteLine("Quantity " + qty);
            Console.WriteLine("total amount " + tot);
        }
    }
    internal class Product
    {
        static void Main(string[] args)
        {
            int id, q;
            string name;
            double price;
            Console.WriteLine("enter product ID");
            id = int.Parse(Console.ReadLine());
            Details d = new Details(id);
            Console.WriteLine("enter product name");
            name = Console.ReadLine();
            Console.WriteLine("enter Quantity");
             q= int.Parse(Console.ReadLine());
            Console.WriteLine("enter price");
            price= int.Parse(Console.ReadLine());
            d.setName(name);
            d.setprice(price);
            d.setQuantity(q);
            d.show();
        }
    }
}
