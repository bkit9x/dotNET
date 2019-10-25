using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManager
{
    class nhap_ds_k_biet_slg_sv
    {
        static void Main(string[] args)
        {
            Console.Write("so luong sinh vien: ");
            char tieptuc;
            List<SinhVien> sv = new List<SinhVien>();
            do
            {
                Console.WriteLine("Nhap thong tin cho sinh vien thu {0}", sv.Count+1);
                Console.Write("\tHo ten: ");
                string hoTen = Console.ReadLine();
                Console.Write("\tGioi tinh: [0] Nam [1] Nu: ");
                string gioiTinh = Console.ReadLine();
                Console.Write("\tNgay sinh: ");
                string ngaySinh = Console.ReadLine();
                Console.Write("\tChuyen nganh cua sinh vien: [1] Van [2] CNTT [Any key] Vat Ly: ");
                char k = char.Parse(Console.ReadLine());
                switch (k)
                {
                    case '1':
                        double coDien, hienDai;
                        Console.Write("\tNhap diem van co dien: ");
                        coDien = double.Parse(Console.ReadLine());
                        Console.Write("\tNhap diem van hien dai: ");
                        hienDai = double.Parse(Console.ReadLine());
                        sv.Add(new SinhVienVan(hoTen, gioiTinh, ngaySinh, coDien, hienDai));
                        break;
                    case '2':
                        double csharp, pascal, sql;
                        Console.Write("\tNhap diem C#: ");
                        csharp = double.Parse(Console.ReadLine());
                        Console.Write("\tNhap diem Pascal: ");
                        pascal = double.Parse(Console.ReadLine());
                        Console.Write("\tNhap diem SQL: ");
                        sql = double.Parse(Console.ReadLine());
                        sv.Add(new SinhVienCNTT(hoTen, gioiTinh, ngaySinh, csharp, pascal, sql));
                        break;
                    default:
                        double co, dien, hatnhan, quang;
                        Console.Write("\tNhap diem Co hoc: ");
                        co = double.Parse(Console.ReadLine());
                        Console.Write("\tNhap diem Dien hoc: ");
                        dien = double.Parse(Console.ReadLine());
                        Console.Write("\tNhap diem Vat ly Hat nhan: ");
                        hatnhan = double.Parse(Console.ReadLine());
                        Console.Write("\tNhap diem Quang hoc: ");
                        quang = double.Parse(Console.ReadLine());
                        sv.Add(new SinhVienVL(hoTen, gioiTinh, ngaySinh, co, dien, hatnhan, quang));
                        break;
                }
                Console.Write("Nhap tiep: [1] Dong y [any key] Dung lai: ");
                tieptuc = char.Parse(Console.ReadLine());
            } while (tieptuc == '1');


            //in ds sv
            for (int i = 0; i < sv.Count; i++)
            {
                Console.WriteLine("{0,3}, {1}", i + 1, sv[i]);
            }

            //in ds sv dtb > 5
            Console.WriteLine("danh sach sinh vien co diem tb tren 5");
            for (int i = 0; i < sv.Count; i++)
            {
                if (sv[i].dtb() > 5)
                {
                    Console.WriteLine("{0,3}, {1}", i + 1, sv[i]);
                }
            }
            //sap xep ds sv theo dtb giam dan
            SinhVien tmp = new SinhVien("", "1", "");
            for (int i = 1; i < sv.Count - 1; i++)
            {
                for (int j = i; j < sv.Count; j++)
                {
                    if (sv[i].dtb() < sv[j].dtb())
                    {
                        tmp = sv[i];
                        sv[i] = sv[j];
                        sv[j] = tmp;
                    }

                }
            }
            //in 3 sv co diem tb cao nhat truong
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sv[i]);
            }
            Console.ReadLine();
        }

    }

    public class SinhVien
    {
        public string hoTen;
        public bool gioiTinh;
        public DateTime ngaySinh;

        public SinhVien(string name, string sex, string dob)
        {
            this.hoTen = name;
            sex = sex.Trim().ToUpper();
            this.gioiTinh = (sex == "NAM" || sex == "MALE" || sex == "1");
            try
            {
                this.ngaySinh = DateTime.Parse(dob);
            }
            catch (Exception)
            {
                this.ngaySinh = DateTime.Today;
            }
        }
        public virtual double dtb()
        {
            return -10;
        }
        public override string ToString()
        {
            return string.Format("{0,10} {1:0.00}", this.hoTen, this.dtb());
        }
    }

    class SinhVienCNTT : SinhVien
    {
        double csharp, pascal, sql;
        public override double dtb()
        {
            return (csharp + pascal + sql) / 3;
        }
        public SinhVienCNTT(string name, string sex, string dob, double cs, double pc, double sl) : base(name, sex, dob)
        {
            this.csharp = cs;
            this.pascal = pc;
            this.sql = sl;
        }
        public override string ToString()
        {
            return string.Format("{0,10} {1,10} {2:0.00}", this.hoTen, "CNTT", this.dtb());
        }

    }
    class SinhVienVan : SinhVien
    {
        double coDien, hienDai;
        public override double dtb()
        {
            return (coDien + hienDai) / 2;
        }
        public SinhVienVan(string name, string sex, string dob, double classic, double modern) : base(name, sex, dob)
        {
            this.coDien = classic;
            this.hienDai = modern;
        }
        public override string ToString()
        {
            return string.Format("{0,10} {1,10} {2:0.00}", this.hoTen, "Van", this.dtb());
        }

    }

    public class SinhVienVL : SinhVien
    {
        double co, dien, hatNhan, quang;
        public override double dtb()
        {
            return (co + dien + hatNhan + quang) / 4;
        }
        public SinhVienVL(string name, string sex, string dob, double co, double dien, double hatnhan, double quang) : base(name, sex, dob)
        {
            this.co = co;
            this.dien = dien;
            this.hatNhan = hatnhan;
            this.quang = quang;
        }
        public override string ToString()
        {
            return string.Format("{0,10} {1,10} {2:0.00}", this.hoTen, "Vat Ly", this.dtb());
        }
    }

}
