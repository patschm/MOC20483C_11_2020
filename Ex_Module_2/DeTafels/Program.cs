using System;

namespace DeTafels
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //double c = a / (double)b;
            //Console.WriteLine(c);

            int tafel = VraagNaarTafel();
            ShowTafel(tafel);

        }

        static void ShowTafel(int tafel)
        {
            Console.WriteLine($"De tafel van {tafel}");
            for (long teller = 1; teller <= 10; teller++)
            {
                long uitkomst = teller * tafel;
                //Console.WriteLine("{0} x {1} = {2}", teller, tafel, uitkomst);
                Console.WriteLine($"{teller,-2} x {tafel} = {uitkomst}");
            }
        }

        private static int VraagNaarTafel()
        {
            do
            {
                Console.WriteLine("Welke tafel?");
                string sTafel = Console.ReadLine();
                try
                {
                    int tafel = int.Parse(sTafel);
                    return tafel;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Ongeldige tafel");
                }
            }
            while (true);
        }
    }
}
