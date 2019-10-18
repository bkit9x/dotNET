using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a, b, c;
            Console.WriteLine("Nhập a, b, c:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a!=0)
            {
                double delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    Console.WriteLine("Phương trình có 2 nghiệm:");
                    Console.WriteLine("x1 = {0}", (-b - Math.Sqrt(delta)) / 2.0 * a);
                    Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(delta)) / 2.0 * a);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phương trình có nghiệm kép:");
                    Console.WriteLine("x1 = x2 = {0}", -b / 2.0 * a);
                }
                else
                    Console.WriteLine("Phương trình vô nghiệm");
            }
            else
            {
                
                Console.WriteLine("Phương trình có nghiệm x = {0}", - c / b);

            }
            Console.ReadLine();
        }
    }
}
