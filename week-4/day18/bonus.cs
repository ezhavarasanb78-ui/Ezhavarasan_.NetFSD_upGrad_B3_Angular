using System;
using System.Collections.Generic;
using System.Text;

namespace set1
{
    internal class bonus
    {
        static void Main(String[] args)
        {
            string name;
            double salary, bon=0, final;
            int exp;
            Console.WriteLine("enter name :");
            name = Console.ReadLine();
            Console.WriteLine("enter salary :");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter experience :");
            exp = int.Parse(Console.ReadLine());

            if(exp<2)
            {
                bon = salary * 0.05;
            }
            else if(exp>2 && exp <=5 )
            {
                bon = salary * 0.10;
            }
            else if(exp>5)
            {
                bon = salary * 0.15;
            }
            final = salary + bon;
            Console.WriteLine("final salary :" + final);
        }
    }
}
