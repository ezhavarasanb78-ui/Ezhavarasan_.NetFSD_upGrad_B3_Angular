using System;
using System.Collections.Generic;
using System.Text;

namespace set1
{
    internal class Employee
    {
        private string name;
        private int age;
        private decimal salary;
        private readonly id;


        public string Name()
        {
            get{ return name; }
            set
                {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("name cannot be empty");
                    name = value.Trim();
                }
            }
        }
        public int Age()
        {
            get{ return age; }
            set
                {
                if (value < 18 || value > 80)
                {
                    throw new ArgumentException("age must be in between 18 and 80");
                    age = value;
                }
            }
        }
        public decimal Salary()
        {
            get{ return salary; }
            set
                {
                if (value < 1000)
                {
                    throw new ArgumentException("salary must be equal or greater than 1000");
                    salary = value;
                }
            }
        }
        public int EmployeeID()
        {
            get(return id;)
        }

        public Employee(string name, int age, decimal salary, int id)
        {
            Name = name;
            Age = age;
            Salary = salary;
            EmployeeID = id;
        }
        public void raise(decimal p)
        {
            if (p <= 0 || p > 30)
            {
                throw new ArgumentException("Raise must be 0 to 30");

            }
            Salary = Salary + (Salary * p / 10);
        }
        public bool dp(decimal d)
        {
            if(d<=0)
            {
                return false;
            }
            else if(Salary-d<1000)
            {
                return false;
            }
            Salary = Salary - d;
            return true;
        }
    }
}
