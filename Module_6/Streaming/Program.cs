using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteToStream();
            //ReadFromStream();
            //PrettigWrite();
            //PrettigRead();
            //CompressWrite();
            //CompressRead();
        }

        private static void CompressRead()
        {
            FileInfo fi = new FileInfo(@"E:\nice.zip");
            FileStream fs = fi.OpenRead();
            GZipStream gzip = new GZipStream(fs, CompressionMode.Decompress);
            StreamReader rdr = new StreamReader(gzip);
            string line;
            while ((line = rdr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        private static void CompressWrite()
        {
            FileInfo fi = new FileInfo(@"E:\nice.zip");
            FileStream file = fi.Create();
            GZipStream gzip = new GZipStream(file, CompressionMode.Compress);
            StreamWriter writer = new StreamWriter(gzip);
            for (int i = 0; i < 1000; i++)
            {
                writer.WriteLine($"Hello World {i}");
            }
            writer.Flush();
            file.Close();
        }

        private static void PrettigRead()
        {
            FileInfo fi = new FileInfo(@"E:\nice.txt");
            FileStream fs = fi.OpenRead();
            StreamReader rdr = new StreamReader(fs);
            string line;
            while ((line = rdr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        private static void PrettigWrite()
        {
            FileInfo fi = new FileInfo(@"E:\nice.txt");
            FileStream file = fi.Create();
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < 1000; i++)
            {
                writer.WriteLine($"Hello World {i}");
            }
            writer.Flush();
            file.Close();
        }

        private static void ReadFromStream()
        {
            FileInfo fi = new FileInfo(@"E:\data.txt");
            FileStream fs = fi.OpenRead();

            byte[] buffer = new byte[12];

            int nrRead = fs.Read(buffer, 0, buffer.Length);
            while(nrRead > 0)
            {
                string data = Encoding.UTF8.GetString(buffer, 0, nrRead);
                Console.Write(data);
                //Array.Clear(buffer, 0, buffer.Length);
                nrRead = fs.Read(buffer, 0, buffer.Length);
            }
        }

        private static void WriteToStream()
        {
            FileInfo fi = new FileInfo(@"E:\data.txt");

            //FileStream file = new FileStream(fi.FullName, FileMode.OpenOrCreate, FileAccess.Write);
            FileStream file = fi.Create();

            for (int i = 0; i < 1000; i++)
            {
                byte[] buffer = Encoding.UTF8.GetBytes($"Hello World {i}\r\n");
                file.Write(buffer, 0, buffer.Length);
            }

            file.Close();

        }
    }
}
