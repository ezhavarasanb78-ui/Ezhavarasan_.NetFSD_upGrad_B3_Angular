using System;
using System.Collections.Generic;
using System.Text;

namespace day26
{
    internal class Order
    {
        public static async Task VPA()
        {
            Console.WriteLine("verifying payment");
            await Task.Delay(2000);
            Console.WriteLine("verified payment");
        }
        public static async Task CIA()
        {
            Console.WriteLine("Checking Inventory");
            await Task.Delay(1500);
            Console.WriteLine("Checked the Inventory");
        }
        public static async Task OCA()
        {
            Console.WriteLine("Confiriming Order");
            await Task.Delay(1000);
            Console.WriteLine("Order connfirmed");
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("order processing please wait");
            await VPA();
            await CIA();
            await OCA();
            Console.WriteLine("order placed");
        }
    }
}
