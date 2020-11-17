using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    class Test
    {
        
    }

    struct Point<T> where T:  new()
    {
        public T X { get; set; }
        public T Y { get; set; }

        public static T Create()
        {
            return new T();
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            object o1 = x; // o1 staat op de heap. Boxing
            int y = (int)o1;  // unboxing

            ArrayList list = new ArrayList();
            //List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach(int xx in list)
            {
                Console.WriteLine(xx);
            }

            Test t = Point<Test>.Create();

            Point<float> p1 = new Point<float> { X = 100F, Y = 200F };
            Console.WriteLine(p1);
            DoeIets(p1);
            Console.WriteLine(p1);
        }

        private static void DoeIets(Point<float> pp)
        {
            pp.X = 1000F;
            pp.Y = 2000F;
        }
    }
}
