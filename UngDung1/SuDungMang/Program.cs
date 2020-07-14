using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungMang
{
    class Program
    {
        static void Main(string[] args)
        {
            KhaiBaoMang();
            


        }

        private static void KhaiBaoMang()
        {
            int[] chieuCao = new int[6];
            chieuCao[0] = 160;
            //chieuCao[1] = 160;
            //chieuCao[2] = 160;
            //chieuCao[3] = 160;
            //chieuCao[4] = 160;
            //chieuCao[5] = 160;
            //Console.WriteLine(chieuCao[0]);

            for (int i = 0; i < chieuCao.Length; i++)
            {
                Console.WriteLine("nhap chieu cao");
                int.TryParse(Console.ReadLine(), out chieuCao[i]);
                
            }
            // xuat mang ra mang hinh
            for (int i = 0; i < chieuCao.Length; i++)
            {
                Console.WriteLine(chieuCao[i]);
            }
            Console.WriteLine("Nhung nguoi cao hon 160cm");
            for (int i = 0; i < chieuCao.Length; i++)
            {
                if (chieuCao[i] > 160) {
                    Console.WriteLine(chieuCao[i]);
                }
            }

        }
    }
}
