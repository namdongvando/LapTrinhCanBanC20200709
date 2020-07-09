using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine("Pt co nghiem: {0}",-b/a);

            }





        }
    }
}
