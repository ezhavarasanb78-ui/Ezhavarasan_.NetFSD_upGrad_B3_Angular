using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace discon
{
    public interface IPrinter
    {
        void Print();
    }
    public interface IScanner
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    public class BasicPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Basic Printer: Printing document...");
        }
    }
    public class AdvancedPrinter : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Advanced Printer: Printing document...");
        }
        public void Scan()
        {
            Console.WriteLine("Advanced Printer: Scanning document...");
        }
        public void Fax()
        {
            Console.WriteLine("Advanced Printer: Sending fax...");
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            IPrinter basic = new BasicPrinter();
            basic.Print();
            AdvancedPrinter advanced = new AdvancedPrinter();
            advanced.Print();
            advanced.Scan();
            advanced.Fax();
            Console.ReadLine();
        }
    }
}
