using System;
using System.IO;

namespace day24
{
    internal class sample
    {
        static void Main(string[] args)
        {
            string str = "D:\\upgrad";

            DirectoryInfo d = new DirectoryInfo(str);

            if (!d.Exists)
            {
                Console.WriteLine("Invalid path");
                return;
            }

            DirectoryInfo[] folders = d.GetDirectories();

            if (folders.Length == 0)
            {
                Console.WriteLine("No subdirectories found");
                return;
            }

            foreach (DirectoryInfo i in folders)
            {
                int count = i.GetFiles().Length;
                Console.WriteLine($"{i.Name} -> {count} files");
            }
        }
    }
}