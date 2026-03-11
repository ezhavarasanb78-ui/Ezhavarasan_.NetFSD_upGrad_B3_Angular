namespace set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int marks;
            Console.WriteLine("Enter name : ");
            name = Console.ReadLine();
            Console.WriteLine("enter marks : ");
            marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks>100)
            {
                Console.WriteLine("Invalid marks");
            }
            else if(marks>=90)
            {
                Console.WriteLine("name : " + name);
                Console.WriteLine(" Grade : A");
            }
            else if (marks >= 75 && marks < 90)
            {
                Console.WriteLine("name : " + name);
                Console.WriteLine(" Grade : B");
            }
            else if (marks >=60 && marks<75)
            {
                Console.WriteLine("name : " + name);
                Console.WriteLine(" Grade : C");
            }
            else if (marks >=40 && marks <60)
            {
                Console.WriteLine("name : " + name);
                Console.WriteLine(" Grade : D");
            }
            else
            {
                Console.WriteLine("Fail");
               
            }




        }
    }
}
