using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeoBuaBao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Chuoi  oan tu ti");
            Console.WriteLine("0.Keo");
            Console.WriteLine("1.Bua");
            Console.WriteLine("2.Bao");
            Console.WriteLine("Ban Chon: ");

            string[] chon = { "keo ", "bua", "bao" };

            
            int nguoi;
            int.TryParse(Console.ReadLine(), out nguoi);
            int keo = 0;
            int bua = 1;
            int bao = 2;
            Random ran = new Random();
            int may = ran.Next(0, 3);
            if (may == nguoi) {
                Console.WriteLine("Hoa");
            } else if ((nguoi == keo && may == bua)||
                (nguoi == bua && may == bao) ||
                (nguoi == bao && may == keo) 
                ) {
                Console.WriteLine("Thua");

            }
            else {
                Console.WriteLine("Thang");

            }
            Console.WriteLine(@"nguoi chon:{0} 
, may chon: {1}",chon[nguoi],chon[may]);





        }
    }
}
