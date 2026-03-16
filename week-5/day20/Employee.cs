using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    class Salary
    {
        public string name { get; set; }
        public double Bsal { get; set; }
        public virtual double Csal()
        {
            return Bsal;
        }
    }
    class Manager : Salary
    {
        public override double Csal()
        {
            return Bsal+(Bsal*0.20);
        }
    }
    class Developer : Salary
    {
        public override double Csal()
        {
            return Bsal + (Bsal * 0.10);
        }
    }
    internal class Employee
    {
        static void Main(string[] args)
        {
            double bsal = 50000;
            Salary man = new Manager();
            man.Bsal = bsal;
            Salary dev = new Developer();
            dev.Bsal = bsal;
            Console.WriteLine("Manager Salary: " + man.Csal());
            Console.WriteLine("Developer Salary: " + dev.Csal());
        }
    }
}
