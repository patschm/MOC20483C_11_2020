using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtils
{
    public static class Utilities
    {
        public static string Keerom(this string s)
        {
            char[] tmp = s.ToCharArray();
            Array.Reverse(tmp);
            return new string(tmp).ToUpper();
        }
    }
}
