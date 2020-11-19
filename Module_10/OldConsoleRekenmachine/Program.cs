using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldConsoleRekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSynchronous();
            TestAPM();
            Console.WriteLine("En verder....");
            Console.ReadLine();
        }

        private static void TestAPM()
        {
            Func<decimal, decimal, decimal> d = LongAdd;
            IAsyncResult ar = d.BeginInvoke(3, 4, CallbackFn, d);

            //while (!ar.IsCompleted)
            //{
            //    Console.Write(".");
            //    Task.Delay(200).Wait();
            //}
            //decimal res = d.EndInvoke(ar);
            //Console.WriteLine(res);
        }

        private static void CallbackFn(IAsyncResult ar)
        {
            Func<decimal, decimal, decimal> d = ar.AsyncState as Func<decimal, decimal, decimal>;
            decimal res = d.EndInvoke(ar);
            
            Console.WriteLine(res);
        }

        private static void TestSynchronous()
        {
            decimal res = LongAdd(1, 2);
            Console.WriteLine(res);
        }

        static decimal LongAdd(decimal a, decimal b)
        {
            Task.Delay(5000).Wait();
            return a + b;
        }
    }
}
