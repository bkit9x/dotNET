using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap26
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
                Console.WriteLine("Nhập phần tử thứ {0}", i + 1);
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Các phần tử nằm ở vị trí chẳn:");
            for (int i = 0; i < n; i+=2)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            bool cothutu = true;
            if (arr[0]>arr[1])
                for (int i = 1; i < n - 1; i++)
                    if (arr[i] < arr[i + 1])
                    {
                        cothutu = false;
                        break;
                    }
                    else
                for (int j = 1; j < n - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        cothutu = false;
                        break;
                    }
            if (cothutu)
                Console.WriteLine("mảng có thứ tự");
            else Console.WriteLine("Mảng không có thứ tự");

            bool codoixung = true;
            for (int i = 0; i < n; i++)
                if (arr[i] != arr[n - i - 1])
                {
                    codoixung = false;
                    break;
                }
            if (codoixung)
                Console.WriteLine("Mảng có đối xứng");
            else
                Console.WriteLine("Mảng không có đối xứng");



            int m, k;
            Console.WriteLine("Nhập số phần tử M:");
            m = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhập vị trí bắt đàu k:");
            k = Convert.ToInt16(Console.ReadLine());
            int[] sarr = new int[m];
            int vtk = 0;
            if (k<n)
            {
                while (vtk < m && vtk+k < n)
                {
                    sarr[vtk] = arr[vtk + k];
                    vtk++;
                }
            }
            Console.WriteLine("Mảng chứa " + m + " phần tử bắt đầu từ vị trí " + k + " là: ");
            for (int i = 0; i < vtk; i++)
            {
                Console.WriteLine(sarr[i]+ " ");
            }
            

            Console.ReadLine();
        }
    }
}
