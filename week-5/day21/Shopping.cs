using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    class Product
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("price greater than zero");

                }
                else
                {
                    price = value;
                }
            }
        }
        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }
    class Electronics : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05);
        }
    }
    class Clothing : Product
    {
        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15);
        }
    }
    internal class Shopping
    {
        static void Main(string[] args)
        {
            Product ele = new Electronics();
            ele.Name = "Lap";
            ele.Price = 45000;
            double fp = ele.CalculateDiscount();
            Console.WriteLine("final price " + fp);
        }
    }
}
