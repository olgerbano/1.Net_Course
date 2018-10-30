using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7b
{
    class Utils
    {
        public static void Reverse(ref string initialstring)
        {
            char[] stringArray = initialstring.ToCharArray();
            string reversestring = String.Empty;
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reversestring += stringArray[i];
            }
            initialstring = reversestring;
        }
    }
}
