using System;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestSynchronous();
            //TestAPM();
            TestTPL();
            Console.WriteLine("En verder....");
            Console.ReadLine();
        }

        
        private static void TestTPL()
        {
            //Task t = new Task(()=>
            //{
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine("Doet iets");
            //});

            Task<decimal> t = new Task<decimal>(() =>
            {
                decimal res = LongAdd(3, 4);
                return res;
            });
            t.ContinueWith(pt =>
            {
                decimal res = pt.Result;
                Console.WriteLine(res);
            });
            t.ContinueWith(pt => { Console.WriteLine($"Die andere {pt.Result}"); });

            //LongAddAsync(5,6).ContinueWith(pt => {
            //    decimal res = pt.Result;
            //    Console.WriteLine(res);
            //});

            t.Start();


        }

        // Old school.
        // Werkt niet in dotnet core
        private static void TestAPM()
        {
            Func<decimal, decimal, decimal> d = LongAdd;
            IAsyncResult ar = d.BeginInvoke(3, 4, null, null);

            while(!ar.IsCompleted)
            {
                Console.Write(".");
                Task.Delay(200).Wait();
            }

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
        static Task<decimal> LongAddAsync(decimal a, decimal b)
        {
            return Task.Run(() => LongAdd(a, b));

            //Task<decimal> t = new Task<decimal>(() => {
            //    decimal res = LongAdd(3, 4);
            //    return res;
            //});
            //t.Start();
            //return t;
        }
    }
}
