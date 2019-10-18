using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble;
            decimal myDecimal;
            myDouble = 3.14;
            myDecimal = 3.14M;
            Console.WriteLine("My Double: {0}", myDouble);
            Console.WriteLine("My Decimal: {0}", myDecimal);
            Console.ReadLine();
        }
    }
}
