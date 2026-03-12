namespace Day2
{
    class Calculator
    {
        public int add(int x,int y)
        {
            return x + y;
        }
        public int sub(int x,int y)
        {
            return x - y;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter number 1 :");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2 :");
            num2 = int.Parse(Console.ReadLine());
            Calculator cal = new Calculator();
            int sum = cal.add(num1, num2);
            int minus = cal.sub(num1, num2);
            Console.WriteLine("Addition of two numbers :" + sum);
            Console.WriteLine("Subtraction of two numbers :" + minus);
        }
    }
}
