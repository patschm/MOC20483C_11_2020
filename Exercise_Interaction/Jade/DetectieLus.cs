using IEEE;
using System;
using System.Collections.Generic;

namespace Jade
{
    public delegate void Activate();

    public class DetectieLus
    {
        //public delegate void Activate();

        private List<IActivatable> _devices = new List<IActivatable>();
        public event Activate Detecting;

        public void Connect(params IActivatable[] devices)
        {
            _devices.AddRange(devices);
        }

        public void Detect()
        {
            Console.WriteLine("De detectielus ziet iets");
            Detecting?.Invoke();
            //foreach(IActivatable device in _devices)
            //{
            //    device.Activate();
            //}
        }
    }
}
