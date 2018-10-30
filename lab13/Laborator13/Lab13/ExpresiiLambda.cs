using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class ExpresiiLambda
    {
        public static void Main()
        {
            int[] vector = { 1, 5, 2, 9, 4, 0 };

            /////Sorteaza vectorul "vector" folosind ordonarea inversa
            //Array.Sort sorteaza elementele crescator, in functie de relatia de ordine
            //-1 inseamna ca primul este mai mic decat al doilea (se pastreaza ordinea)
            // 0 inseamna ca primul este egal cu al doilea (se pastreaza ordinea)
            // 1 inseamna ca primul este mai mare decat al doilea (se inverseaza ordinea)
            // expresia y-x face ca x si y sa fie in ordine atunci cand x < y
            Array.Sort(vector, (x, y) => y - x);

            foreach (int i in vector)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
