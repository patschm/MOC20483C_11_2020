using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuweTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"E:\TestDir";
            string file = "blah.txt";

            DirectoryInfo di = new DirectoryInfo(dir);
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo fi = new FileInfo($@"{dir}\{file}");
           // fi.GetAccessControl()

        }
    }
}
