using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AocCommon
{    public class p2Element
    {
        public p2Element(int min,
        int max,
        char ruleChar,
        string password)
        {
            Min = min;
            Max = max;
            Char = ruleChar;
            Password = password;
        }

        public int Min;
        public int Max;
        public char Char;
        public string Password;
    }
}
