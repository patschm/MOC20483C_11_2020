using IEEE;
using System;
using System.Collections.Generic;

namespace Jade
{
   

    public class DetectieLus
    {
        private List<IActivatable> _devices = new List<IActivatable>();

        public void Connect(params IActivatable[] devices)
        {
            _devices.AddRange(devices);
        }

        public void Detect()
        {
            Console.WriteLine("De detectielus ziet iets");
            foreach(IActivatable device in _devices)
            {
                device.Activate();
            }
        }
    }
}
