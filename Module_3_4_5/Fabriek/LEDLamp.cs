using System;
using System.Collections.Generic;
using System.Text;

namespace Fabriek
{
    class LEDLamp : Lamp
    {
        public bool IsHalfGeleider { get; set; }

        public override void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De LED brandt met {Lumen} lumen");
        }
        public override void Uit()
        {
            Console.WriteLine("De LED gaat uit");
            Console.ResetColor();
        }
    }
}
