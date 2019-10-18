using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double dcb, dnc;
            string xeploai;

            Console.WriteLine("Nhập điểm cơ bản:");
            dcb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm nâng cao:");
            dnc = Convert.ToDouble(Console.ReadLine());
            double dtb = (dcb + dnc) / 2.0;
            if (dtb >= 9 && dcb >= 8 && dnc >= 8)
            {
                xeploai = "Xuất sắc";
            }
            else if (dtb >= 8 && dcb >= 7 && dnc >= 7)
            {
                xeploai = "Giỏi";
            }
            else if (dtb >= 7 && dcb >= 6 && dnc >= 6)
            {
                xeploai = "Khá";
            }
            else if (dtb >= 5 && dcb >= 3 && dnc >= 3)
            {
                xeploai = "Trung bình";
            }
            else
                xeploai = "Không đạt";
            Console.WriteLine("Xếp loại: {0}", xeploai);




            Console.ReadLine();
        }
    }
}
