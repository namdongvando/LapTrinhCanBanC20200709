

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); 

        }

        private static void Menu()
        {
            Console.WriteLine("============");
            Console.WriteLine("1. Giai Phuong trinh bac 1");
            Console.WriteLine("2. Giai Phuong trinh bac 2");
            Console.WriteLine("3. Tim so lon nhat");
            Console.WriteLine("Chon: ");
            string chon = "1";
            chon = Console.ReadLine();
            switch (chon) {
                case "1":
                    GiaiPhuongTrinhBac1();
                    break;
                case "2":
                    GiaiPhuongTrinhBac2();
                    break;
                case "3":
                    TimMaxMin();
                    break;
                case "exit":
                    return;
                default:
                    return;
            }
            Menu();


        }

        private static void TimMaxMin()
        {
            int a, b, c, max, min;
            Console.WriteLine("Nhap a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Nhap c");
            int.TryParse(Console.ReadLine(), out c);
            max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine("So lon nhat la{0}", max);

            min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            Console.WriteLine("So nho nhat la{0}", min);
        }

        private static void GiaiPhuongTrinhBac2()
        {
            double a, b, c, d, x1, x2;
            //nhap du lieu tu ban phim
            Console.WriteLine("Nhap a=");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b=");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Nhap c=");
            double.TryParse(Console.ReadLine(), out c);
            d = b * b - 4 * a * c;
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("pt vo nghiem");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("pt co nghiem la X1={0} X2={1}", x1, x2);

            }

        }

        private static void GiaiPhuongTrinhBac1()
        {
            double a, b, c;
            Console.WriteLine("Nhap a");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Nhap b");
            double.TryParse(Console.ReadLine(), out b);

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Pt vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Pt vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Pt co nghiem: {0}", -b / a);

            }
        }

        private static void XinChao(string ten)
        {
            Console.WriteLine("Xin Chao: {0}",ten);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chao");
        }
    }
}
