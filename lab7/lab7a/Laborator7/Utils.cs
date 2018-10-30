using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator7
{
    class Utils
    {
        public static void Reverse(ref string initialString)
        {
            string reverseString = "";
            for (int i = initialString.Length - 1; i >= 0; i--)
                reverseString += initialString[i];
            initialString = reverseString;
        }
    }
}
