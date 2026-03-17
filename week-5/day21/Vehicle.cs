using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    class Transport
    {
        private string brand;
        private double rentday;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double Rentday
        {
            get { return rentday; }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Insufficent Days");
                }
                else
                {
                    rentday = value;
                }
            }
        }
        public virtual double Calculaterent(int days)
        {
            return rentday * days;
        }
    }
    class Bike : Transport
    {
        public override double Calculaterent(int days)
        {
            if(days<=0)
            {
                Console.WriteLine("Invalid number of days");
            }
            double tot = Rentday * days;
            return tot - (tot * 0.05);
        }
    }
    class Car : Transport
    {
        public override double Calculaterent(int days)
        {
            if(days<=0)
            {
                Console.WriteLine("Invalid number of days");
            }
            double tot = Rentday * days;
            return tot = tot + 500;
        }

    }
    internal class Vehicle
    {
        static void Main(string[] args)
        {
            int days = 3;
            Transport t = new Car();
            t.Brand = "Audi";
            t.Rentday = 2000;
            double tot= t.Calculaterent(days);
            Console.WriteLine("vehicle brand " + t.Brand);
            Console.WriteLine("total rent : "+tot);

            Transport b = new Bike();
            b.Brand = "NS16";
            b.Rentday = 600;
            double total = b.Calculaterent(days);
            Console.WriteLine("Vehicle brand " + b.Brand);
            Console.WriteLine("total rent: "+ total);

        }
    }
}
