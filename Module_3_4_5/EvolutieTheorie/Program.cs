using System;
using System.Collections.Generic;

namespace EvolutieTheorie
{
    delegate int MathDel(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            int res = Add(1, 2);

            // .NET 1.0/1.1 (2002/2003)
            MathDel m1 = new MathDel(Add);
            res = m1(2, 3);

            // .NET 2.0
            MathDel m2 = Add;
            res = m2(3, 4);

            int c = 100;

            MathDel m3 = delegate (int a, int b)
             {
                 return a + b + c;
             };
            res = m3(4, 5);

            // .NET 3.0 (2007)
            // Lambda's
            MathDel m4 = (a, b) => a + b + c;
            res = m4(5, 6);

            // Voorgedefinieerde delegates
            // EventHandler (oeroude)
            // Predicate<int> (in onbruik geraakt)
            // Procedures. Action
            // Functions. Func<int>
            Action<string> cw = Console.WriteLine;
            // cw(res.ToString());

            Func<int, int, int> m5 = Add;
            res = m5(6, 7);

            Func<int, int, int, int> m6 = (int a, int b, int c) => a + b + c;
            res = m6(1, 2, 3);

            res = Subtract(4, 5);
            // C# 7.3 (2017)
            int Subtract(int a, int b)
            {
                return a - b + c;
            };

            Console.WriteLine(res);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
