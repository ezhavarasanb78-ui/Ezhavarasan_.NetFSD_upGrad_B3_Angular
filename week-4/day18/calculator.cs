using System;
using System.Collections.Generic;
using System.Text;

namespace set1
{
    internal class calculator
    {
        static void Main(String[] args)
        {
            char op;
            int num = 15;
            int num2 = 10;
            op = Convert.ToChar(Console.ReadLine());
            
            switch(op)
            {
                case '+':
                    Console.WriteLine("result : "+ (num + num2));
                    break;

                case '-':
                    Console.WriteLine("result : "+ (num - num2));
                    break;
                case '*':
                    Console.WriteLine("result : "+ (num * num2));
                    break;
                case '/':
                    if(num2==0)
                    {
                        Console.WriteLine("cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("result :"+  (num / num2));
                    }
                    break;
            }
        }
    }
}
