using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilangan_prima
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilangan, ulang, sisa, jumlahbilangan;
            string ket;

            Console.Write("Masukan Bilangan Prima =");
            bilangan = Convert.ToInt16(Console.ReadLine());
            jumlahbilangan = 0;
            for (ulang = 1; ulang <= bilangan; ulang++)
            {
                sisa = bilangan % ulang;
                if (sisa == 0)
                    jumlahbilangan = jumlahbilangan + 1;
                else
                    jumlahbilangan = jumlahbilangan;
            }
            if (jumlahbilangan > 2)
                ket = "Bukan Bilangan Prima";
            else
                ket = "Bilangan Prima";
            Console.WriteLine("=" + ket);
            Console.ReadKey();

        }
    }
}
