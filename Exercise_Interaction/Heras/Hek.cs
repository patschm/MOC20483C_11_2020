using IEEE;
using System;

namespace Heras
{
    public class Hek: IActivatable
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("Het hek opent");
        }
    }
}
