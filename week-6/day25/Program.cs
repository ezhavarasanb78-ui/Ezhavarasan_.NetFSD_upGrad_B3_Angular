using System;
using System.Threading.Tasks;
namespace day26
{
    internal class Program
    {
        public static async Task writelogAsync(string mes)
        {
            Console.WriteLine($"starts {mes}");
            await Task.Delay(2000);
            Console.WriteLine($"finished {mes}");
        }
        public static async Task readlogAsync(string mes)
        {
            Console.WriteLine($"starts {mes}");
            await Task.Delay(2000);
            Console.WriteLine($"finished {mes}");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("logging starts");
            Task t1 = writelogAsync("user logged");
            Task t2 = readlogAsync("file uploaded");
            Task t3 = writelogAsync("error");
            await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("successfully");
        }
    }
}
