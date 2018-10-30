using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Exercitiul3
    {
        public static void PrintLength(dynamic obj)
        {
            Console.WriteLine("lungime: " + obj.Length);
        }
        public static void Main()
        {
            int[] vector = new int[10];
            string cuvant = "mamaliga";

            //Se afiseaza vector.Length
            PrintLength(vector);
            //Se afiseaza cuvant.Length
            PrintLength(cuvant);

            Console.ReadKey();
        }
    }
}
