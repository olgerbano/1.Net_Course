using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7b
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            Utils.Reverse(ref test);
            Console.WriteLine("Reverse  String  Is  {0}", test);
            Console.ReadKey();
        }
    }
}
