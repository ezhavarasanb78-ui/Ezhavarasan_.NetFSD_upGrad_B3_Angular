using System;
using System.Collections.Generic;
using System.Text;

namespace day24
{
    internal class Admin
    {
        static void Main(string[] args)
        {
            string s= "D:\\upgrad\\Ezhavarasan_.NetFSD_upGrad_B3_Angular\\week-1\\day1\\";

            try
            {
                if(!sample.Exists(s))
                {
                    Console.WriteLine("invalid file");
                    return;
                }
                string[] f = sample.GetFiles(s);
                int count = 0;
                foreach (var i in f)
                {
                    FileInfo fi = new FileInfo(i);
                    Console.WriteLine("file name: " + fi.Name);
                    Console.WriteLine("file Size: " + fi.Length);
                    Console.WriteLine("file createdtime: " + fi.CreationTime);
                    count++;
                    Console.WriteLine("total files: " + count);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("error");
            }
        }
    }
}
