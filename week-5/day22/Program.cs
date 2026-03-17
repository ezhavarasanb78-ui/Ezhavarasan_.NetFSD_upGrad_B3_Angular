namespace day22
{
    class Calculator
    {
        public void div(int num,int den)
        {
            try
            {
                int res = num / den;
                Console.WriteLine("result " + res);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("error cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("completed");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            int den = 0;
            Calculator cal = new Calculator();
            cal.div(num, den);
            Console.WriteLine("program runs");
        }
    }
}
