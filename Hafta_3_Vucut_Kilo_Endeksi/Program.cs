using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3_Vucut_Kilo_Endeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            string soyad;
            byte kilo = 0;
            double boy = 0;
            Console.WriteLine("Adınız: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Kilogram Cinsinden kilonuzu giriniz: ");
            kilo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Boyunuzu metre cinsinden giriniz (Örnek: 1,68): ");
            boy = Convert.ToDouble(Console.ReadLine());
            if ((kilo / boy / boy >= 18.5) && (kilo / boy / boy < 25))
            {
                Console.WriteLine("Normal Kilodasınız...");
            }
            else if ((kilo / boy / boy >= 25) && (kilo / boy / boy < 30))
            {
                Console.WriteLine("Fazla Kilolusunuz...");
            }
            else if ((kilo / boy / boy >= 30) && (kilo / boy / boy < 35))
            {
                Console.WriteLine("Obezsin !!!");
            }
            Console.ReadKey();
        }
    }
}
