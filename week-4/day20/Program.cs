namespace set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Ezhavarasan",23,28000,78);


            console.WriteLine(emp.Name());
            console.WriteLine(emp.Age());
            emp.raise(20);
            console.WriteLine(emp.Salary());
            bool res = emp.dp(200);
            console.WriteLine(res);

        }
    }
}
