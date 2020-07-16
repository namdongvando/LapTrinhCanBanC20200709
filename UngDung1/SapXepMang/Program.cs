using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXepMang
{
    class Program
    {
        static void Main(string[] args)
        {

            //  SapXepMangNoiBot();
            SapXepMangChonTrucTiep();

        }

        private static void SapXepMangChonTrucTiep()
        {
            int[] a = { 23, 14, 21, 7, 5, 2, 0 };

            Array.Sort(a);

            int tam;

            for (int j = 0; j < a.Length; j++)
            {
                int min = j;
                for (int i = j; i < a.Length; i++)
                {
                    if (a[i] < a[min])
                        min = i;
                }
                tam = a[j];
                a[j] = a[min];
                a[min] = tam;

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        private static void SapXepMangNoiBot()
        {
            int[] a = { 23, 14, 21, 7, 5, 2, 0 };
            int i = 0;
            int tam;
            while (true)
            {
                if (i + 1 == a.Length)
                    break;
                if (a[i] > a[i + 1])
                {
                    tam = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tam;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
    }
}
