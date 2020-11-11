using System;
using System.Collections.Immutable;
using System.Linq;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] gg = str.ToArray();
            Array.Sort(gg);
            return new string(gg);
        }
    }
}
