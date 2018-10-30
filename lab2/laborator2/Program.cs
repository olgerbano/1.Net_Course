using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laborator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Sir ! What is your name? ");
            string myname = Console.In.ReadLine();
            Console.WriteLine("Hello " + myname);
            //Console.ReadKey();
            Console.Write("Enter a text: ");
            string string1 = Console.In.ReadLine();
            Console.Write("Enter another text: ");
            string string2 = Console.In.ReadLine();
            string1 = Regex.Replace(string1, @"!", "");
            string2 = Regex.Replace(string2, @"_", "");
            string string3 = string.Concat(string1, string2);
            Console.WriteLine(string3);
            

            //version 2
            Console.WriteLine("Introdu numele tau : ");
            string myName1 = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName1);
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            while (s1.IndexOf("!") != -1)
            {
                s1 = s1.Remove(s1.IndexOf("!"), 1);
            }
            while (s2.IndexOf("_") != -1)
            {
                s2 = s2.Remove(s2.IndexOf("_"), 1);
            }


            string str = string.Concat(s1, s2);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
