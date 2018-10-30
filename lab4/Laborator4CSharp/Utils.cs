using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator4CSharp
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        public static void swap(ref int a, ref int  b)
        {
            int x, y;
            int temp = a;
                a = b;
                b = temp;
            x = a;
            y = b;
        }

        public static bool Factorial1(int n, ref int answer)
        {
            int k, f = 1;
            for (k = 2; k <= n; k++)
            {
                if (f < 0)
                {
                    answer = 0;
                    return false;
                }
                else
                {
                    f = f * k;
                }
            }
            answer = f;
            return true;
        }

        public static bool Factorial(int n, ref int answer)
        {

            if (n == 1 ) return true;

            answer *= n;
            return  Factorial( n-1 , ref answer);
                
            

           

        }
    }
}

