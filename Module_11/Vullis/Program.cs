using System;

namespace Vullis
{
    class Program
    {
        static UnmanagedIets r1 = new UnmanagedIets();
        static UnmanagedIets r2 = new UnmanagedIets();
        
        static void Main(string[] args)
        {
            try
            {
                r1.Open();
            }
            finally
            {
                r1.Dispose();
            }
            r1 = null;

            // MOet je niet willen!
            GC.Collect();
            GC.WaitForPendingFinalizers();
            using (r2)
            {
                r2.Open();
            }

            using(UnmanagedIets r3 = new UnmanagedIets())
            {
                r3.Open();
            }

        }
    }
}
