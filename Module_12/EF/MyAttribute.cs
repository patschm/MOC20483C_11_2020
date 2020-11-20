using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method )]
    public class MyAttribute : Attribute
    {
        public int Age { get; set; }
    }
}
