using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace FilesEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestStatics();
            //TestInstances();
            //EDrive();
            //DemoPerfLoss();
            Console.ReadLine();
        }

        private static void DemoPerfLoss()
        {
            //string s = "";
            StringBuilder s = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < 100000;i++)
            {
                // s += i.ToString();
                s.Append(i.ToString());
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        private static void EDrive()
        {
            DriveInfo ed = new DriveInfo("E:");
            Console.WriteLine(ed.Name);
            ShowContent(ed.RootDirectory);
        }

        private static void ShowContent(DirectoryInfo dir)
        {
            Console.WriteLine(dir.Name);
            try
            {
                foreach (DirectoryInfo di in dir.GetDirectories())
                {
                    Console.WriteLine(di.FullName);
                    ShowContent(di);
                }
                foreach (FileInfo fi in dir.GetFiles())
                {
                    Console.WriteLine(fi.FullName);
                }
            }
            catch(Exception e)
            {
                
            }
        }

        private static void TestInstances()
        {
            DriveInfo dr = new DriveInfo("C:");
            
            string dir = @"E:\TestDir";
            string file = "blah.txt";

            DirectoryInfo di = new DirectoryInfo(dir);
            if (!di.Exists)
            {
                di.Create();
            }
            FileInfo fi = new FileInfo(@$"{dir}\{file}");
            
            if (!fi.Exists)
            {
                fi.Create().Close();
            }
            fi.Attributes = FileAttributes.Normal;

            di.Delete(true);
        }

        private static void TestStatics()
        {
            string dir = @"E:\TestDir";
            string file = "blah.txt";
            // Directory.CreateDirectory(dir);
            //File.Create(@$"{dir}\{file}").Close();
            //File.SetAttributes($@"{dir}\{file}", FileAttributes.Hidden | FileAttributes.System);
            //FileAttributes attr = File.GetAttributes($@"{dir}\{file}");
            //Console.WriteLine(attr);
            Directory.Delete(dir, true);
        }
    }
}
