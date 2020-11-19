using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {


        static void Main(string[] args)
        {

            //TestSynchronous();
            //TestAPM();
            //TestTPL();
            //TestHipster();
            //MoreFunWithTasks();
            //TestFouten();
            //EchtParallelAsync();
            SharingIsCaring();
            Console.WriteLine("En verder....");
            Console.ReadLine();
        }

        static object stokje = new object();

        private static void SharingIsCaring()
        {
            int number = 0;

            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            ConcurrentDictionary<int, int> big1;

            bag.Add("hoi");
            bag.ToList();

            //Parallel.For(0, 10, idx => { });

            for(int i = 0; i < 10; i++)
            {
                Task.Run(() => {
                    lock (stokje)
                    {
                        int tmp = number;
                        Task.Delay(1000).Wait();
                        number = ++tmp;
                        Console.WriteLine(number);
                    }
                });
            }

        }

        private static async Task EchtParallelAsync()
        {
            int a = 0, b = 0;

            var t1 = Task.Run(() =>
                {
                    Task.Delay(2000).Wait();
                    return 10;
                }).ContinueWith(pt => a = pt.Result);
            var t2 = Task.Run(() =>
            {
                Task.Delay(4000).Wait();
                return 20;
            }).ContinueWith(pt => b = pt.Result);

            await Task.WhenAll(t1, t2);
            int res = a + b;
            Console.WriteLine(res);
        }

        private static async void TestFouten()
        {
            //ErrorTask().ContinueWith(pt => {
            //    Console.WriteLine(pt.Status);
            //    if (pt.Exception != null)
            //    {
            //        Console.WriteLine(pt.Exception.InnerException.Message);
            //    }
            //});

            try
            {
                await ErrorTask();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static Task ErrorTask()
        {
            return Task.Run(() =>
            {
                Task.Delay(1000).Wait();
                throw new Exception("Ooops");
            });
        }

        private static void MoreFunWithTasks()
        {
            CancellationTokenSource nikko = new CancellationTokenSource();
            DoeIetsAsync(nikko.Token);
            Console.WriteLine("Press enter to stop.");
            Console.ReadLine();
            nikko.Cancel();
            Console.WriteLine(".....");
        }
        static Task DoeIetsAsync(CancellationToken bommetje = default(CancellationToken))
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    //bommetje.ThrowIfCancellationRequested();
                    if (bommetje.IsCancellationRequested)
                    {
                        return;
                    }
                    Task.Delay(1000).Wait();
                    Console.WriteLine($"Task {i}");
                }
            });
        }

        private static async void TestHipster()
        {
            //Task<decimal> t = Task.Run(() =>
            //{
            //    decimal res = LongAdd(3, 4);
            //    return res;
            //});

            //decimal res = await t;  // Soft return
            //decimal res = t.Result;

            decimal res = await LongAddAsync(8, 9);
            Console.WriteLine(res);
            Console.WriteLine("Vervolg");
        }

        private static void TestTPL()
        {
            //Task t = new Task(()=>
            //{
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine("Doet iets");
            //});

            Task<decimal> t = Task.Run(() =>
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

            // t.Start();


        }

        // Old school.
        // Werkt niet in dotnet core
        private static void TestAPM()
        {
            Func<decimal, decimal, decimal> d = LongAdd;
            IAsyncResult ar = d.BeginInvoke(3, 4, null, null);

            while (!ar.IsCompleted)
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
