using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vullis
{
    class UnmanagedIets : IDisposable
    {
        private static bool isOpen = false;
        private FileStream file;

        private bool isDisposing = false;

        public void Open()
        {
            if (!isOpen)
            {
                Console.WriteLine("Opening...");
                isOpen = true;
                file = new FileStream(@"E:\bla.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            else
            {
                Console.WriteLine("Helaas. In gebruik");
            }
        }
        public void Close()
        {
            Console.WriteLine("Closing...");
            isOpen = false;
        }

        protected virtual void Dispose(bool fromFinalizer)
        {
            Close();
            if (!fromFinalizer)
            {
                file.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(this);
        }

        ~UnmanagedIets()
        {
            Dispose(true);
        }
    }
}
