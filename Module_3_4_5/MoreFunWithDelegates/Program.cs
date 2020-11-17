using System;

namespace MoreFunWithDelegates
{
    delegate int Bereken(int s, int c);

    class Program
    {
        static void Main(string[] args)
        {
            Bereken b1 = Subtract;
            b1 += Add;
            b1 += Subtract;
            b1 += Subtract;

            int result = b1(3, 4);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
