using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    static class StringExtension
    {
        public static string CreateIndentation(this string str, int level)
        {
            // caracterul '\t' reprezinta TAB
            switch (level)
            {
                case 1:
                    str = "\tx " + str;
                    break;
                case 2:
                    str = "\t\t+ " + str;
                    break;
                case 3:
                    str = "\t\t\to " + str;
                    break;
            }

            return str;
        }
    }

    // Exercitiul 4 se foloseste de codul din clasa StringExtension definita anterior
    public class Exercitiul4
    {
        public static void Main()
        {
            Console.WriteLine("heading 1".CreateIndentation(1));
            Console.WriteLine("heading 2".CreateIndentation(2));
            Console.WriteLine("heading 3".CreateIndentation(3));

            Console.ReadKey();
        }
    }
}
