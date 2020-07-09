using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimMaxMin
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("So lon nhat la{0}",max);

            min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            Console.WriteLine("So nho nhat la{0}", min);
            
        }
    }
}
