using DoomsdayPreppers;
using Heras;
using Jade;
using Philips;
using System;

namespace Mijnhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp();
            DetectieLus lus = new DetectieLus();
            Valkuil kuil = new Valkuil();
            Hek gate = new Hek();

            lus.Connect(lamp, kuil, gate);

            lus.Detect();
        }
    }
}
