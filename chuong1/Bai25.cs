using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            do
            {
                Console.WriteLine("Nhập n:");
                n = Convert.ToInt16(Console.ReadLine());

            } while (n <= 0);
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập phần tử thứ {0}", i+1);
                arr[i] = Convert.ToInt16(Console.ReadLine());                
            }
            Console.WriteLine("Mảng vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Các phần tử lớn nhất nằm ở vị trí: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == max)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();

            long tong = 0;
            double slg=0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i]>0)
                {
                    tong += arr[i];
                    slg++;
                }
            }
            Console.WriteLine("Trị trung bình: {0}", tong/slg);

            int k;
            do
            {
                Console.WriteLine("Nhập k:");
                k = Convert.ToInt16(Console.ReadLine());

            } while (k <= 0);
            int demluythua = 0;

            for (int i = 0; i < n; i++)
            {
                int j = 0;
                double pow = Math.Pow(k, j);
                while (pow <= arr[i])
                {
                    if (pow == arr[i])
                    {
                        demluythua++;
                        break;
                    }
                    pow = Math.Pow(k, j);
                    j++;
                }
            }

            Console.WriteLine("Số phần tử là lũy thừa của {0} là: {1}", k, demluythua);

            Console.ReadLine();
        }
    }
}
