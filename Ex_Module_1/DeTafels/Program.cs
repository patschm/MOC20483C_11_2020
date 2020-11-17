using System;

namespace DeTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int tafel = 1; tafel <= 10; tafel++)
            {
                Console.WriteLine($"De tafel van {tafel}");
                for (int teller = 1; teller <= 10; teller++)
                {
                    int uitkomst = teller * tafel;
                    //Console.WriteLine("{0} x {1} = {2}", teller, tafel, uitkomst);
                    Console.WriteLine($"{teller, -2} x {tafel} = {uitkomst}");
                }
            }
        }
    }
}
