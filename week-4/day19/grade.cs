using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Student
    {
        public double avgr(int x,int y,int z)
        {
            double average = (x + y + z) / 3.0;
            return average;
        }
    }
    internal class grade
    {
        static void Main(string[] args)
        {
            int m1, m2, m3;
            Console.WriteLine("enter three numbers:");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            m3 = int.Parse(Console.ReadLine());
            Student s = new Student();
            double avg = s.avgr(m1, m2, m3);
            String grad;
            if(avg>=80)
            {
                grad = "A";
            }
            else if(avg>=60 && avg<80)

            {
                grad = "B";
            }
            else if(avg>=40 && avg<60)
            {
                grad = "C";
            }
            else
            {
                grad = "fail";
            }
            Console.WriteLine("Average = " + avg + " grade : " + grad);
        }
    }
}
