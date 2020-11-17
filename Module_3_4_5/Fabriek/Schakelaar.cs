using System;
using System.Collections.Generic;
using System.Text;

namespace Fabriek
{
    interface IDevice
    {
        void Aan();
        void Uit();
    }

    class Schakelaar
    {
        public IDevice Device { get; set; }

        public void Aan()
        {
            Device.Aan();
        }
        public void Uit()
        {
            Device.Uit();
        }
    }
}
