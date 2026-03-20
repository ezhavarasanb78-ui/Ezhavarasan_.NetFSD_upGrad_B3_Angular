using System;
using System.Collections.Generic;
using System.Text;

namespace day24
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string n = Console.ReadLine();
            Console.WriteLine("enter sale");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("enter rating");
            int r = int.Parse(Console.ReadLine());
            if(r<1 || r>5)
            {
                Console.WriteLine("enter rating between 1 to 5");
                return;
            }
            var data = getdata(s, r);
            string op = (data.s, data.r) switch
            {
                ( >= 100000, >= 4) => "high performance ",
                ( >= 50000, >= 3) => "Average performance ",
                _ => "need improvement"
            };
            Console.WriteLine("name : " + n);
            Console.WriteLine("sales : " + data.s);
            Console.WriteLine("rating : " + data.r);
            Console.WriteLine("perfomance : " +op );
        }
        static(double s,int r) getdata(double s,int r)
        {
            return (s, r);
        }
    }
}
