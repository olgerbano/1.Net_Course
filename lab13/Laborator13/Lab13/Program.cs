using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class Exercitiul1
    {
        public static int FilterCount(int[] vector, int min, int max = int.MaxValue, int divisor = 1)
        {
            int count = 0;

            foreach (int elem in vector)
                if (elem >= min && elem <= max)
                    if (elem % divisor == 0)
                        count++;

            return count;
        }

        public static void Main()
        {
            int[] vector = { 1, 24, 13, 26, 15, 9, 30, 17, 32 };
            int rez;

            rez = FilterCount(vector, max: 20, min: 0);
            Console.WriteLine("{0} elemente satisfac filtrul [0, 10]", rez);
            rez = FilterCount(vector, 5, divisor: 2);
            Console.WriteLine("{0} elemente satisfac filtrul >= 5 si divizibile cu 2", rez);
            rez = FilterCount(vector, 0, divisor: 2, max: 20);
            Console.WriteLine("{0} elemente satisfac filtrul [0, 20] si divizibile cu 2", rez);

            Console.ReadKey();
        }
    }
}
