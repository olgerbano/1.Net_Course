using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator4CSharp
{
    class Test
    {
        
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max is " + Utils.Greater(x, y));
             Utils.swap(ref x,ref y);
            Console.WriteLine(x + " " + y);
            Console.WriteLine("Enter a number to calculate factorial");
            int fact = Convert.ToInt32(Console.ReadLine());
            int rezultat = 1;
            bool xxx = Utils.Factorial1(fact, ref rezultat);
            Console.WriteLine("rezultatul factorialului este " + rezultat);
            Console.ReadLine();
        }
    }
}
