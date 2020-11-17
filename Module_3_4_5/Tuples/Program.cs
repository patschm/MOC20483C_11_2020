using System;

namespace Tuples
{
    class Values
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            (int, int) v = (100, 200);
            (int Val1, int Val2) nv = DoeIets(v);

            Console.WriteLine(nv.Val1);
        }

        private static (int, int) DoeIets((int Val1, int Val2) v)
        {
            return (v.Val1 + 10, v.Val2 + 10 );
        }
    }
}
