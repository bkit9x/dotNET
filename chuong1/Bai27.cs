using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int m, n;
            Console.WriteLine("Nhập m:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập n:");
            n = Convert.ToInt32(Console.ReadLine());
            double[,] arr = new double[m, n];

            Console.WriteLine("Nhập ma trận:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Nhập hàng {0} cột {1} :", i+1, j+1);
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma trận vừa nhập:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            int dem1 = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((int)arr[i,j] % 2 == 0)
                    {
                        dem1++;
                    }
                }
            }
            Console.WriteLine("Số phần tử có phần nguyên là chẳn: " + dem1);

            int h;
            do
            {
                Console.WriteLine("Nhập hàng h:");
                h = Convert.ToInt32(Console.ReadLine());
            } while (h<0 || h>m);

            double tich = 1;
            for (int i = 0; i < n; i++)
            {
                tich *= arr[h,i];
            }
            Console.WriteLine("tích các phần tử nằm trên hàng {0} = {1}",h,tich);


            int c;
            do
            {
                Console.WriteLine("Nhập cột c:");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c < 0 || c > m);

            double tmp;
            for (int i = 0; i < m-1; i++)
            {
                for (int j = i; j < m; j++)
                {
                    if(arr[i, c] > arr[j, c])
                    {
                        tmp = arr[i, c];
                        arr[i, c] = arr[j, c];
                        arr[j, c] = tmp;
                    }
                }
            }
            Console.WriteLine("Mảng sau khi sắp xếp: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
