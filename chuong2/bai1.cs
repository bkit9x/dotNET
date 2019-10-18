using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;

            phanso a, b;
            a = new phanso();
            b = new phanso();

            a.nhap();
            a.toigian();
            a.tinhtoan();

            b.nhap();
            b.xuat();
            if(a>=b)
                Console.WriteLine("phân số thứ nhất lớn hơn phân số thứ hai");
            
            Console.ReadLine();
        }
    }
    class phanso
    {
        private int tu, mau;
        //public phanso()
        //{
        //}
        //public phanso(int tuso, int mauso)
        //{
        //    tu = tuso;
        //    mau = mauso;
        //}
        public void nhap()
        {
            Console.WriteLine("Nhập tử số: ");
            tu = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Nhập mẫu số (khác 0): ");
                mau = Convert.ToInt32(Console.ReadLine());
            } while (mau == 0);
        }

        public int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }

        public void toigian()
        {
            int ucln = UCLN(tu, mau);
            tu = tu / ucln;
            mau = mau / ucln;
        }

        public void xuat()
        {
            //-a, -b : a/b <=> -a/-b 
            //a, -b: -a/b  <=> -a/-b

            //-a, b : -a/b <=> a/b
            //a, b : a/b   <=> a/b

            //nếu tử chia hết cho mẫu thì in ra dạng số nguyên
            if (tu % mau == 0)
                Console.WriteLine(tu/mau);
            else if ((tu < 0 && mau < 0) || (tu >= 0 && mau < 0))
                Console.WriteLine("{0}/{1}", -tu, -mau);
            else
                Console.WriteLine("{0}/{1}", tu, mau);
        }

        public void tinhtoan()
        {
            char pt;
            do
            {
                Console.WriteLine("nhập phép tính: ");
                // Console.ReadLine()[0] : chỉ lấy kí tự ở vị trí đầu tiên (0), nếu người dùng nhập +-*/ thì chỉ lấy phép toán +
                pt = Console.ReadLine()[0];
            } while (pt != '+' && pt != '-' && pt != '*' && pt != '/');
            phanso q = new phanso();
            q.nhap();
            switch (pt)
            {
                case '+':
                    tu = tu * q.mau + q.tu * mau;
                    mau = mau * q.mau;
                    break;
                case '-':
                    tu = tu * q.mau - q.tu * mau;
                    mau = mau * q.mau;
                    break;
                case '*':
                    tu *= q.tu;
                    mau *= q.mau;
                    break;
                case '/':
                    tu *= q.mau;
                    mau *= q.tu;
                    break;
                default:
                    break;
            }
            Console.WriteLine("kết quả");

            //tối giản phân số trước khi in ra
            toigian();
            xuat();
        }

        public static phanso operator +(phanso p, phanso q)
        {
            phanso kq = new phanso();
            kq.tu = p.tu * q.mau + p.mau * q.tu;
            kq.mau = p.mau * q.mau;
            return kq;
        }
        public static phanso operator -(phanso p, phanso q)
        {
            phanso kq = new phanso();
            kq.tu = p.tu * q.mau - p.mau * q.tu;
            kq.mau = p.mau * q.mau;
            return kq;
        }
        public static phanso operator *(phanso p, phanso q)
        {
            phanso kq = new phanso();
            kq.tu = p.tu * q.tu;
            kq.mau = p.mau * q.mau;
            return kq;
        }
        public static phanso operator /(phanso p, phanso q)
        {
            phanso kq = new phanso();
            kq.tu = p.tu * q.mau;
            kq.mau = p.mau * q.tu;
            return kq;
        }

        public static bool operator <(phanso p, phanso q)
        {
            return p.tu * q.mau < q.tu * p.mau;
        }
        public static bool operator >(phanso p, phanso q)
        {
            return p.tu * q.mau > q.tu * p.mau;
        }
        public static bool operator <=(phanso p, phanso q)
        {
            return p.tu * q.mau <= q.tu * p.mau;
        }
        public static bool operator >=(phanso p, phanso q)
        {
            return p.tu * q.mau >= q.tu * p.mau;
        }
        public static bool operator ==(phanso p, phanso q)
        {
            return p.tu * q.mau == q.tu * p.mau;
        }
        public static bool operator !=(phanso p, phanso q)
        {
            return p.tu * q.mau != q.tu * p.mau;
        }
    }
}
