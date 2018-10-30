using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Exercitiul2
    {
        struct Point3D
        {
            public int x, y, z;
        }

        public static void Main()
        {
            Point3D point = new Point3D() { x = 1, y = 2, z = 3 };
            var variable = new { oy = point.y, oz = point.z };

            Console.WriteLine(variable.oy + " " + variable.oz);

            Console.ReadKey();
        }
    }
}
