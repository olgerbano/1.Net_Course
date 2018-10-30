using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutieLaborator7
{
    class TestReverseString
    {
        static void Main()
        {
            string myString;
            Console.WriteLine("Stringul pentru revers:");
            myString = Console.ReadLine();
            Utils.Reverse(ref myString);

            Console.WriteLine("Stringul intors: {0}",myString);
        }
    }
}
