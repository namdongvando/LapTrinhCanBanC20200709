using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocLuc
{
    class Program
    {
        static void Main(string[] args)
        {
            double diem;
            Console.WriteLine("Nhap diem");
            double.TryParse(Console.ReadLine(), out diem);
            if (diem < 0 || diem > 10)
            {
                Console.WriteLine("du lieu khong phu hop");

            }
            else {
                // diem 0-10
                #region cach 1
                if (diem <= 3.5)
                {
                    Console.WriteLine("Kem");
                }
                else if (diem < 5)
                {
                    Console.WriteLine("Yeu");
                }
                else if (diem < 6.5)
                {
                    Console.WriteLine("Trung binh");
                }
                else if (diem < 8.5)
                {
                    Console.WriteLine("Kha");
                }
                else { 
                    Console.WriteLine("Gioi");

                }
                #endregion

                #region Cach 2
                if (diem >= 0 && diem <= 3.5) {
                    Console.WriteLine("Kem");
                }
                if (diem > 3.5 && diem < 5)
                {
                    Console.WriteLine("Yeu");
                }
                if (diem >=5 && diem < 6.5)
                {
                    Console.WriteLine("Trung Binh");
                }
                if (diem >= 6.5 && diem < 8.5)
                {
                    Console.WriteLine("Kha");
                }
                if (diem >= 8.5 && diem <= 10)
                {
                    Console.WriteLine("Gioi");
                }
                #endregion
            }


        }
    }
}
