using System;
using System.Collections.Generic;
using System.Text;

namespace day26
{
    internal class Financial
    {
        public static void GSR()
        {
            Console.WriteLine("generating sales reports");
            Thread.Sleep(3000);
            Console.WriteLine("finishesd sales reports");
        }
        public static void GIR()
        {
            Console.WriteLine("generating inventory reports");
            Thread.Sleep(2000);
            Console.WriteLine("finishesd Inventory reports");
        }
        public static void GCR()
        {
            Console.WriteLine("generating Customer reports");
            Thread.Sleep(2500);
            Console.WriteLine("finishesd Customer reports");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("starting all reports");
            Task t1 = Task.Run(() => GSR());
            Task t2 = Task.Run(() => GIR());
            Task t3 = Task.Run(() => GCR());
            Task.WaitAll(t1, t2, t3);
            Console.WriteLine("All reports generated successfully");
        }
    }
}
