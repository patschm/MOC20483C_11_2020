using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Virtuele wereld (Big bang)
            // Variabelen
            // ----------------------
            // Type varnaam;
            // ----------------------
            string name;
            name = "Jan";
            int age = 42;
            bool isHuman = true;

            // Scope. Wordt bepaald door { }
            {
                long lifetime = 40000000000;
                //Console.WriteLine(lifetime);
                //Console.WriteLine(age);
            }

            // Expressions.
            // 1-3 operands (variable of literal) waarop een operator werkt
            // 1 Operand (unaire)
            age++;  // age = age + 1
            age--;
            ++age;  // age = age + 1

            // 2 operands (binaire)
            int result = age + 10;

            // 3 operands (ternaire)
            string res = isHuman ? "Mens" : "Geen mens";

            // Nullable types
            int? leeftijd = null;
            int final = leeftijd.HasValue ? leeftijd.Value: 42;
            final = leeftijd ?? 42;

            // Flows
            // Jump forward.
            // if (expression moet altijd true of false opleveren)
            if (age < 43)
            {
                // true
            }
            else if (age > 60)
            {
                // false
            }

            switch(age)
            {
                case 9:
                case 10:
                        // whatever
                        break;
                case 20:
                        // ...
                        break;
                default:
                    {
                        // alle andere gevallen
                        break;
                    }
            }

            // Jump back (loops)
            // for loop gebruik je als je weet hoe vaak iets herhaald moet worden
            int x = 0;
            for (;x < 10; x++)
            {
                if (x == 5) continue;
                Console.WriteLine(x);
            }

            // while loop
            // 0 of meer keer uitgevoerd
            // data uitlezen
            while (age < 60)
            {
                // whatever
            }

            // do while
            // 1 of meer keer uitvoeren
            // Vaak in UI
            do
            {
                // whatever
            }
            while (age < 70);

            // Big Crunch
        }
    }
}
