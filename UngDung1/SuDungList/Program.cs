using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double canhHV = 2.4;
                double dienTich = TinhDienTichHinhVuong(canhHV);
                Console.WriteLine("Dien tich hinh vuong la{0}"
                    , dienTich);
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static double TinhDienTichHinhVuong(double canhHV)
        {
            double s = canhHV * canhHV;
            return s;
        }

        private static List<double> GiaiPTBac2(double a, double b, double c)
        {
            if (a == 0)
                throw new Exception("khong phai pt bac2");
            //double d = Math.Pow(b, 2) - 4 * a * c;
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                throw new Exception("Vo nghiem");
            }
            List<double> nghiem = new List<double>();
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            nghiem.Add(x1);
            nghiem.Add(x2);
            return nghiem;
        }

        private static double NhapSo(string thongBao)
        {
            Console.WriteLine(thongBao);
            double a;
            double.TryParse(Console.ReadLine(), out a);
            return a;
        }

        private static double GiaiPTBac1(double a, double b)
        {
            if (a == 0)
                if (b == 0)
                    throw new Exception("Pt Vo so nghiem");
                else
                    throw new Exception("Pt Vo nghiem");
            return -b / a;
        }

        private static int NhapTuoi()
        {
            Console.WriteLine("Nhap Tuoi");
            return int.Parse(Console.ReadLine());
        }

        private static string NhapTen()
        {
            Console.WriteLine("Nhap Ten");
            return Console.ReadLine();
        }

        private static void XinChao(string ten)
        {
            Console.WriteLine("Xin chao: {0}", ten);
        }

        private static void SuDungListCoBan()
        {
            List<int> a = new List<int>();
            a.Add(4);
            a.Add(5);
            a.Add(7);
            a.Add(8);
            a.Add(2);
            a.Insert(0, 39);
            a.Remove(7);
            a.RemoveAll(item => item > 7);
            a.RemoveAt(2);
            a.RemoveRange(0, 2);

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
