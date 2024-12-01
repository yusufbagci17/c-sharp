using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Saat saat = new Saat();
            saat.Saat_Goster();
            Saat saat2 = new Saat(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            saat2.Saat_Goster();
            */
            Sekil sekil = new Sekil();
            sekil.Boyut = 5;
            sekil.Yazdir();
            Console.ReadKey();
        }
    }
}
