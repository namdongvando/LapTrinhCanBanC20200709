using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDung1
{
    class Program
    {
        static void Main(string[] args)
        {
            //day la dong code xuat dulieu ra man hinh
            Console.WriteLine("Xin chao");
            int a = 4;
            int b = 5;
            Console.WriteLine("So a La: {0}",a);
            Console.WriteLine("So B La: {0}", b);
            int c;
            c = a;
            
            a = b;
            b = c;
            Console.WriteLine(
                "So a La: {0} So B La: {1}",a,b);
            



        }
    }
}
