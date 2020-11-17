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

    delegate void Activeer();

    class Schakelaar
    {
        // Tis nu een event geworden
        public event Activeer funktieAan;
        public event Activeer funktieUit;

        public IDevice Device { get; set; }

        public void Aan()
        {
            funktieAan.Invoke();
            //Device.Aan();
        }
        public void Uit()
        {
            funktieUit();
            //Device.Uit();
        }
    }
}
