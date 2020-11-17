using IEEE;
using System;

namespace DoomsdayPreppers
{
    public class Valkuil : IActivatable
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("De valkuil gaat open");
        }
    }
}
