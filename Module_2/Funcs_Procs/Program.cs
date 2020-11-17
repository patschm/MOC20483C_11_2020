using System;
using System.Diagnostics;
using System.Linq;

namespace Funcs_Procs
{
    class Program
    {
        static void Main(string[] args)
        {
            //CounterCreationData ct = new CounterCreationData("aaaaa", "hellup", PerformanceCounterType.NumberOfItems32);
            //CounterCreationDataCollection col = new CounterCreationDataCollection();
            //col.Add(ct);
            //PerformanceCounterCategory cat = PerformanceCounterCategory.Create("AAAAA", "Hellup", PerformanceCounterCategoryType.SingleInstance, col);

            //PerformanceCounter ct = 
            //DoeIets(1, 2, d:40);
            //int a;
            //DoeIets(out a);
            //Console.WriteLine(a);

            try
            {
                int number = AskNumber();
                // int number = Sommeer(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
                ShowNumber(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        // Procedures
        static void DoeIets(int a, int b, int c = 3, int d = 4, int e = 5)
        {
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
        }

        static void ShowNumber(int nummer)
        {
            Console.WriteLine($"Het opgegeven nummer is: {nummer}");
        }
        static void DoeIets(out int nr)
        {
            nr = 100;
        }

        // Overload
        // De signature van de function/procedure moet uniek zijn.
        // Die bestaat uit de naam, aantal argumenten en soort argumenten
        // Return type maakt geen onderdeel uit van de signature
        static void ShowNumber(long nummer)
        {
            Console.WriteLine($"Het opgegeven nummer is: {nummer}");
        }

        // Functions
        static int AskNumber()
        {
            PerformanceCounter pc = new PerformanceCounter("AAAAA", "aaaaa", false);
           
            do
            { 
                pc.Increment();
                Console.WriteLine("Geef een nummer");
                string sNr = Console.ReadLine();
                try
                {
                    int nr = int.Parse(sNr);
                    return nr;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Geen geldig getal. Probeer het nog eens");
                    Debug.WriteLine(fe.StackTrace);
                    Debug.WriteLine(fe.HResult);
                    Debug.WriteLine(fe.Source);
                    //throw new Exception("Ooops");
                    //throw;
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine($"Getal moet liggen tussen {int.MinValue} en {int.MaxValue}");
                    EventLog.WriteEntry("Application", "Hallo", EventLogEntryType.Error);
                    //EventLog.CreateEventSource("MyLog")
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Altijd aangeroepen");
                }
            }
            while (true);
        }

        static int Sommeer(params int[] nrs)
        {
            return nrs.Sum();
        }



    }
}
