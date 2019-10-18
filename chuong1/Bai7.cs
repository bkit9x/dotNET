using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            char sao = '*';
            char dolar = '$';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sao);
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a)");
            Console.WriteLine("\n\n");

            for (int i = n-1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(dolar);
                }
                Console.WriteLine();
            }
            Console.WriteLine("  b)");
            Console.WriteLine("\n\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < 2*n; j++)
                {
                    if (j>n-i && j<n+i)
                    {
                        Console.Write(sao);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("      c)");
            Console.WriteLine("\n\n");

            Console.ReadLine();
        }
    }
}
