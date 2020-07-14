using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLap
{
    class Program
    {
        static void Main(string[] args)
        {

            NhapSoNguyenDuong();


        }

        private static void NhapSoNguyenDuong()
        {
            int a;
            bool kt = true;
            Console.WriteLine("nhap so nguyen duong");
            do
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == true)
                    if (a < 0)
                        kt = false;
                if (kt == false)
                {
                    Console.WriteLine
                        ("Nhap lai: nhap so nguyen duong");
                }

            } while (kt == false);

        }

        private static void XacDinhNguyenTo()
        {

            int n = 13;
            int i = 2;
            if (n < 2)
            {
                Console.WriteLine("khong la NT");
            }
            while (i <= n)
            {
                if (n % i == 0)
                {
                    if (n == i)
                        Console.WriteLine("{0}la NT", n);
                    else
                        Console.WriteLine("{0}khong la NT", n);
                    break;
                }
                i++;
            }



        }

        private static void TimUCLN()
        {
            int a, b;
            Console.WriteLine("Nhap a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b");
            int.TryParse(Console.ReadLine(), out b);
            while (a * b > 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            Console.WriteLine("UCLN {0}", a + b);

        }

        private static void Xua100SoChanDauTien()
        {
            int dem = 0;
            int i = 0;
            while (i <= 100)
            {
                if (dem % 2 == 0)
                {
                    Console.WriteLine(dem);
                    i++;
                }
                dem++;
            }
        }

        private static void XuatBangCuuChuong()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {2} ={1}", i, i * j, j);
                }
            }

        }

        private static void XuatSoChanTu0Den100()
        {
            for (int i = 0; i <= 100; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);
        }

        private static void SuDungVongLapCanBan()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + "xin chao");
            }
            int tong = 0;
            for (int i = 0; i <= 100; i++)
            {
                tong = tong + i;
            }
            Console.WriteLine("tong tu 1 den 100 : {0}"
                , tong);
        }
    }
}
