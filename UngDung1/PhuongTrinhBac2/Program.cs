using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
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
            if (d<0)
            {
                Console.WriteLine("pt vo nghiem");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("pt co nghiem la X1={0} X2={1}",x1,x2);

            }






        }
    }
}
