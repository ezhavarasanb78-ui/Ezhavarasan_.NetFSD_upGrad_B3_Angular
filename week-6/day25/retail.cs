using System;
using System.Collections.Generic;
using System.Text;

namespace day26
{
    internal class retail
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter product name ");
            string name = Console.ReadLine();
            Console.WriteLine("enter price ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter discount");
            int dis = int.Parse(Console.ReadLine());

            double fp = price - (price * dis / 100);
            Console.WriteLine("final price :" + fp);
        }
    }
}
