using System;
using System.Collections.Generic;
using System.Text;

namespace set1
{
    internal class count
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number :");
            num = int.Parse(Console.ReadLine());
            int ec=0, oc=0, sum=0;
            for(int i=1;i<=num;i++)
            {
                if(i%2==0)
                {
                    ec++;
                }
                else
                {
                    oc++;
                }
                sum = sum + i;
            }
            Console.WriteLine("Even Count :" + ec);
            Console.WriteLine("Odd Count: " + oc);
            Console.WriteLine("Sum :" + sum);

        }
    }
}
