using System;
using Statics.Uuuts;

namespace Statics
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator+(Point p1, Point p2)
        {
            return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }


    class Person
    {
        private static int _instanceCounter;

        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Person._instanceCounter} personen");
        }

        public Person()
        {
            Person._instanceCounter++;
        }
        static Person()
        {
            _instanceCounter = 0;
        }
    }
    namespace Uuuts
    {
        static class Utils
        {
            // Extension method
            public static string ReplaceToUnders(this string s, char rp)
            {
                return s.Replace(' ', rp);
            }
            public static string ToKebabCase(this string s)
            {
                return s.ToLower().Replace(' ', '-');
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World. How are you today";
            string sres = s.ReplaceToUnders('-');   // Utils.ReplaceToUnders(s);
            sres = s.ToKebabCase();

            Console.WriteLine(sres);

            Point a = new Point { X = 10, Y = 20 };
            Point b = new Point { X = 1, Y = 2 };

            Point res = a + b;

            Console.WriteLine(res);


           for(int i = 0; i < 10; i++)
            {
                Person p = new Person();
                //Person.Show();
            }
        }
    }
}
