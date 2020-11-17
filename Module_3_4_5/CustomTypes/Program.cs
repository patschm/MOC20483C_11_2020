using System;
using Bla;

namespace CustomTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welke dag? Hangt ervan af.
            int dag = 2;
            //WeekDay day = WeekDay.Tuesday;
            WeekDay day = (WeekDay)4;
            Console.WriteLine(day);
        }
    }

    namespace Bla
    {
        // Een type dat duiding geeft aan een getal
        enum WeekDay : uint
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saterday = 32,
            Sunday = 64
        }
    }
}

namespace Bla
{
    // Een type dat duiding geeft aan een getal
    enum WeekDay : uint
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saterday = 32,
        Sunday = 64
    }
}


