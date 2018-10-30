using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator3Csharp
{
    class Conv2
    {
        public static void Main()
        {
            Console.WriteLine("Introduceti nr in baza 10");
            int nrB10 = int.Parse(Console.ReadLine());
            int resturi;
            string nrB16 = "";

            while (nrB10 > 0)
            {
                resturi = nrB10 % 16;
                nrB10 /= 16;
                if (resturi < 10)
                {
                    nrB16 = resturi + nrB16;
                }
                if (resturi == 10)
                {
                    nrB16 = "A" + nrB16;
                }
                if (resturi == 11)
                {
                    nrB16 = "B" + nrB16;
                }
                if (resturi == 12)
                {
                    nrB16 = "C" + nrB16;
                }
                if (resturi == 13)
                {
                    nrB16 = "D" + nrB16;
                }
                if (resturi == 14)
                {
                    nrB16 = "E" + nrB16;
                }
                if(resturi == 15)
                {
                    nrB16 = "F" + nrB16;
                }
            }
            Console.WriteLine(nrB16);
            Console.ReadLine();
        }
    }
}
