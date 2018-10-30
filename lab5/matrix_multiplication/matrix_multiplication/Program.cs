using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, m1, n1,m2,n2;
            Console.WriteLine("Enter the Number of Rows and Columns (First Matrix): ");
            m1 = int.Parse(Console.ReadLine());
            // m = Convert.ToInt32(Console.ReadLine());
            n1 = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m1, n1];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n1; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is:");
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n1; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the Number of Rows and Columns (Second Matrix): ");
            m2 = int.Parse(Console.ReadLine());
            // m = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[m2, n2];
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < m2; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < m2; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix Multiplication is :");
            int[,] c = new int[m1, n2];
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n1; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (i = 0; i < m1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

/*
1 2 3 5         1 2
7 8 9 6         7 8
                1 5
                1 2
2x4             4x2                     2x2
*/