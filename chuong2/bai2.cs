using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class bai2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            do
            {
                Console.WriteLine("nhập số lượng sách: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<=0);
            sach[] danhsach = new sach[n];

            //nhập danh sách n sách
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin cho sách thứ {0}", i+1);
                danhsach[i] = new sach();
                Console.WriteLine(">> Tựa Sách: ");
                danhsach[i].TuaSach = Console.ReadLine();
                Console.WriteLine(">> Tác Giả: ");
                danhsach[i].TenTacGia = Console.ReadLine();
                Console.WriteLine(">> Nhà Xuất Bản: ");
                danhsach[i].TenNhaXuatBan = Console.ReadLine();
                Console.WriteLine(">> Năm Xuất Bản: ");
                danhsach[i].NamXuatBan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(">> Số Trang: ");
                danhsach[i].SoTrang = Convert.ToInt32(Console.ReadLine());
            }
            //in danh sách vừa nhập
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n\n ====" + i+1 + "====\n");
                Console.WriteLine("Tựa sách: " + danhsach[i].TuaSach);
                Console.WriteLine("Tên tác giả: " + danhsach[i].TenTacGia);
                Console.WriteLine("Tên nhà xuất bản: " + danhsach[i].TenNhaXuatBan);
                Console.WriteLine("Năm xuất bản: " + danhsach[i].NamXuatBan);
                Console.WriteLine("Số trang: " + danhsach[i].SoTrang);
            }
            //tìm số quyển sách của tác giả X
            string X = Console.ReadLine();
            int soLuong = 0;
            for (int i = 0; i < n; i++)
            {
                if (danhsach[i].TenTacGia == X)
                {
                    soLuong++;
                }
            }
            Console.WriteLine("Có {0} quyển sách của tác giả {1}.", soLuong, X);
            //tính tổng số trang sách xuất bản năm 2013
            int soTrang = 0;
            for (int i = 0; i < n; i++)
            {
                if (danhsach[i].NamXuatBan == 2013)
                {
                    soTrang += danhsach[i].SoTrang;
                }
            }
            Console.WriteLine("Trong năm 2013 đã xuất bản {0} trang sách.", soTrang);
            //tìm số trang của quyển sách dày nhất
            int soTrgSachDayI = danhsach[0].SoTrang;
            for (int i = 1; i < n; i++)
            {
                if (danhsach[i].SoTrang > soTrgSachDayI)
                    soTrgSachDayI = danhsach[i].SoTrang;
            }
            Console.WriteLine("Sách dày nhất có {0} trang", soTrgSachDayI);
            //In tựa, tác giả của những sách có số trang = P
            int p;
            do
            {
                Console.WriteLine("Nhập số trang P: ");
                p = Convert.ToInt32(Console.ReadLine());
            } while (p<=0);
            for (int i = 0; i < n; i++)
            {
                if (danhsach[i].SoTrang == p)
                {
                    Console.WriteLine("Tựa sách: " + danhsach[i].TuaSach);
                    Console.WriteLine("Tên tác giả: " + danhsach[i].TenTacGia);
                    Console.WriteLine();
                }
            }

        }
    }
    class sach
    {
        private string _tuaSach, _tenTacGia, _tenNhaXuatBan;
        private int _namXuatBan, _soTrang;

        public string TuaSach { get => _tuaSach; set => _tuaSach = value; }
        public string TenTacGia { get => _tenTacGia; set => _tenTacGia = value; }
        public string TenNhaXuatBan { get => _tenNhaXuatBan; set => _tenNhaXuatBan = value; }
        public int NamXuatBan { get => _namXuatBan; set => _namXuatBan = value; }
        public int SoTrang { get => _soTrang; set => _soTrang = value; }
    }
}
