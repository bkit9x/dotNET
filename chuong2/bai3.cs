using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2
{
    class bai3
    {

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;

            do
            {
                Console.WriteLine("Nhập số lượng sinh viên: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0 || n > 80);
            sinhvien[] dssv = new sinhvien[n];

            //nhập
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhập thông tin sinh viên thứ {0} : ", i + 1);
                dssv[i] = new sinhvien();
                dssv[i].nhap();
            }
            //in
            Console.WriteLine("\n======danh sách vừa nhập===\n");
            for (int i = 0; i < n; i++)
            {
                dssv[i].xuat();
            }

            //tìm số sinh viên nữ
            Console.WriteLine("\n=========\n");
            int soSVNu = 0;
            for (int i = 0; i < n; i++)
            {
                if (dssv[i].GioiTinh)
                {
                    soSVNu++;
                }
            }
            Console.WriteLine("Lớp có {0} sinh viên nữ", soSVNu);


            //in sv có điểm TB cao nhất
            Console.WriteLine("\n=========\n");
            double Maxdtb = dssv[0].Dtb;
            for (int i = 1; i < n; i++)
            {
                if (dssv[i].Dtb > Maxdtb)
                {
                    Maxdtb = dssv[i].Dtb;
                }
            }
            Console.WriteLine("Sinh viên có điểm trung bình cao nhất({0}) : ", Maxdtb);
            for (int i = 0; i < n; i++)
            {
                if (dssv[i].Dtb == Maxdtb)
                {
                    Console.WriteLine("Họ tên: {0}", dssv[i].HoTen);
                }
            }


            //Sắp xếp dssv giảm dần theo điểm TB;
            Console.WriteLine("\n==== danh sách sinh viên sau khi sắp xếp =====\n");
            sinhvien tmp = new sinhvien();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (dssv[i].Dtb < dssv[j].Dtb)
                    {
                        tmp = dssv[i];
                        dssv[i] = dssv[j];
                        dssv[j] = tmp;
                    }
                }
            }
            // in ds đã sắp xếp:
            for (int i = 0; i < n; i++)
            {
                dssv[i].xuat();
            }

            Console.ReadLine();
        }
    }
    class sinhvien
    {
        private string _maSo, _hoTen, _queQuan, _xepLoai;
        private bool _gioiTinh;
        private int _namSinh;
        private double _dtb;

        public string MaSo { get => _maSo; set => _maSo = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string QueQuan { get => _queQuan; set => _queQuan = value; }
        public string XepLoai { get => _xepLoai; set => _xepLoai = value; }
        public int NamSinh { get => _namSinh; set => _namSinh = value; }
        public double Dtb { get => _dtb; set => _dtb = value; }
        public bool GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }

        public void nhap()
        {
            do
            {
                Console.WriteLine("Nhập mã số: ");
                MaSo = Console.ReadLine();
            } while (!checkMaSo());

            do
            {
                Console.WriteLine("Nhập họ tên: ");
                HoTen = Console.ReadLine();
            } while (!checkHoTen());

            Console.WriteLine("Nhập quê quán: ");
            QueQuan = Console.ReadLine();

            Console.WriteLine("Nhập giới tính (0 : Nam / 1 : Nữ): ");
            GioiTinh = Convert.ToInt16(Console.ReadLine()) == 0 ? false : true;

            do
            {
                Console.WriteLine("Nhập năm sinh (1985-1995): ");
                NamSinh = Convert.ToInt32(Console.ReadLine());
            } while (!checkNamSinh());

            do
            {
                Console.WriteLine("Nhập điểm trung bình: ");
                Dtb = Convert.ToDouble(Console.ReadLine());
            } while (!checkDTB());

            //xếp loại
            if (Dtb >= 3.6)
                XepLoai = "Xuất sắc";
            else if (Dtb >= 3.2)
                XepLoai = "Giỏi";
            else if (Dtb >= 2.5)
                XepLoai = "Khá";
            else if (Dtb >= 2)
                XepLoai = "Trung bình";
            else
                XepLoai = "Yếu";
        }
        public void xuat()
        {
            Console.WriteLine("Mã số: {0}", MaSo);
            Console.WriteLine("Họ tên: {0}", HoTen);
            Console.WriteLine("Quê quán: {0}", QueQuan);
            Console.WriteLine("Giới Tính: {0}", GioiTinh ? "Nữ" : "Nam");
            Console.WriteLine("Năm sinh: {0}", NamSinh);
            Console.WriteLine("Điểm trung bình: {0}", Dtb);
            Console.WriteLine("Xếp loại: {0}", XepLoai);

        }
        private bool checkMaSo()
        {
            //độ dài = 6
            if (MaSo.Length == 6)
            {
                //3 kí tự đầu là chữ
                for (int i = 0; i < 3; i++)
                {
                    if (!char.IsLetter(MaSo[i]))
                    {
                        return false;
                    }
                }
                // và 3 kí tự sau là số
                for (int i = 3; i < 6; i++)
                {
                    if (!char.IsNumber(MaSo[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            //độ dài khác 6 
            return false;
        }
        private bool checkHoTen()
        {
            for (int i = 0; i < HoTen.Length; i++)
            {
                //nếu kí tự không phải chữ hoặc khoảng trắng thì return false
                if (!(char.IsLetter(HoTen[i]) || HoTen[i] == ' '))
                {
                    return false;
                }
            }
            // ho ten đã hợp lệ, tiến hành chuẩn hóa
            string str = HoTen.ToLower();
            char[] result = new char[str.Length];
            char his = ' ';
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && (his == ' ' || i == str.Length-1))
                    j--;
                else if(his == ' ')
                    result[j] = char.ToUpper(str[i]);
                else
                    result[j] = str[i];

                his = str[i];
                j++;
            }
            char[] rs = new char[j];
            for (int i = 0; i < j; i++)
            {
                rs[i] = result[i];
            }
            HoTen = new string(rs);
            return true;
        }
        private bool checkNamSinh()
        {
            if (NamSinh < 1985 || NamSinh > 1995)
            {
                return false;
            }
            return true;
        }
        private bool checkDTB()
        {
            if (Dtb < 0 || Dtb > 4)
                return false;
            return true;
        }
    }
}
