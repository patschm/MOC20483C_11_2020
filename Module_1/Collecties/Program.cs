using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Collecties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array.
            // 1) Aaneengesloten geheugen blok
            // 2) Immutable.
            // Type[] varnaam;
            int[] nrs = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            nrs[0] = 10;
            nrs[1] = 20;

            for (int i = 0; i < nrs.Length; i++)
            {
                int val = nrs[i];
                //Console.WriteLine(val);
            }

            // Iterator design pattern
            foreach(int val in nrs)
            {
                //Console.WriteLine(val);
            }

            int[,] matrix = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            matrix[0, 1] = 20;

            int[,,] kubus = new int[3, 3, 3];


            int[][] jagged = new int[3][];
            jagged[0] = new int[5];
            jagged[1] = new int[10];
            jagged[2] = new int[4];


            List<int> list = new List<int>();
            list.Add(2);

            Console.WriteLine(list[0]);

            Dictionary<string, int> lookup = new Dictionary<string, int>();
            lookup.Add("een", 1);
            lookup.Add("twee", 2);

            Console.WriteLine(lookup["twee"]);
            foreach(var item in lookup)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            int val = queue.Dequeue();

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            val = stack.Pop();

            BitVector32 vect = new BitVector32();
            var sec1 = BitVector32.CreateSection(8);
            vect[sec1] = 7;
            
        }
    }
}
