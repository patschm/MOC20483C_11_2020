using IEEE;
using System;

namespace Philips
{
    public class Lamp : IActivatable
    {
        public void Aan()
        {
            Console.WriteLine("De lamp gaat aan");
        }

        public void Activate()
        {
            Aan();
        }
    }
}
