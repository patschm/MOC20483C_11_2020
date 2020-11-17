using System;

namespace Fabriek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Big bang

            Radio r1 = new Radio();
            Schakelaar s1 = new Schakelaar();
            Lamp l1 = new LEDLamp { Lumen = 300, Kleur = ConsoleColor.Red, IsHalfGeleider=true };
            Lamp l2 = new LEDLamp { Lumen = 300, Kleur = ConsoleColor.Yellow, IsHalfGeleider = true };
            //l1.Lumen = 500;
            //l1.kleur = ConsoleColor.Yellow;

            //s1.Device = l1;
            s1.funktieAan += l1.Aan;
            s1.funktieAan += r1.Spelen;
            s1.funktieAan += l2.Aan;

            s1.funktieUit += l1.Uit;

            s1.Aan();
            Console.WriteLine("Schrijven");
            s1.Uit();
            Console.WriteLine("Schrijven");

            // Big Crunch
        }
    }

    // Blauwdruk van een lamp
    abstract class Lamp: IDevice
    {
        // Fields. Hierin slaan we eigenschappen op.
        private int lumen = 100;
        //private ConsoleColor kleur = ConsoleColor.Yellow;

        // Properties. Voor gecontroleerde toegang voor fields
        // Aut generating property. Genereert zijn eigen field
        public ConsoleColor Kleur  { get;  set; }

        public int Lumen
        {
            get
            {
                return lumen;
            }
            set
            { 
                if (value >= 0 && value < 1000)
                {
                    lumen = value;
                }
            }
        }

        // Methods. Hierin definieren wij het gedrag van een object
        public abstract void Aan();
        //{
        //    Console.BackgroundColor = Kleur;
        //    Console.WriteLine($"De brandt met {Lumen} lumen");
        //}
        public virtual void Uit()
        {
            Console.WriteLine("De laamp gaat uit");
            Console.ResetColor();
        }

        // Constructors. Gebruik je om je fields van een initiele waarde te voorzien
        public Lamp()
        {
            Lumen = 100;
            Kleur = ConsoleColor.Green;
        }
        public Lamp(int lumen)
        {
            Lumen = lumen;
            Kleur = ConsoleColor.Green;
        }
    }
}
