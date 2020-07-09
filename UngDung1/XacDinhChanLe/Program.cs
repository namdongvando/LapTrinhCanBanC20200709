using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhChanLe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so nguyen");
            string soNguyen = Console.ReadLine();
            int a;
            bool kt = int.TryParse(soNguyen, out a);
            if (kt == false) {
                Console.WriteLine("ban nhap khong dung");
                return;
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", a);
            }
            else {
                Console.WriteLine("{0} la so le", a);
            }

            

        }
    }
}
