using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a, b;
            char pt;
            Console.WriteLine("Nhập số thứ nhất:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập phép toán (+ - * ?):");
            pt = Convert.ToChar(Console.Read());

            switch (pt)
            {
                case '+':
                    Console.WriteLine(a + " " + pt + " " + b + " = {0}", a + b);
                    break;
                case '-':
                    Console.WriteLine(a + " " + pt + " " + b + " = {0}", a - b);
                    break;
                case '*':
                    Console.WriteLine(a + " " + pt + " " + b + " = {0}", a * b);
                    break;
                case '/':
                    if (b != 0)
                    {
                        Console.WriteLine(a + " " + pt + " " + b + " = {0}", a / b);
                    }
                    else
                        Console.WriteLine("Mẫu phải khác 0");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
