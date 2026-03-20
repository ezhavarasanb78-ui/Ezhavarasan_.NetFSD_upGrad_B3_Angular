using System;
using System.Collections.Generic;
using System.Text;

namespace day24
{
    internal class ITdisk
    {
        static void Main(string[] args)
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            foreach(DriveInfo d in drive)
            {
                if(d.IsReady)
                {
                    Console.WriteLine("Drive :" + d.Name);
                    Console.WriteLine("Drive type :" + d.DriveType);
                    long tot = d.TotalSize / (1024 * 1024 * 1024);
                    long free = d.AvailableFreeSpace / (1024 * 1024 * 1024);
                    Console.WriteLine("Total space :" + tot);
                    Console.WriteLine("free space:" + free);
                    double per = (double)free / tot * 100;
                    if(per<15)
                    {
                        Console.WriteLine("Low Space" );
                    }
                }
            }
        }
    }
}
