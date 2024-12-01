using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // * Kalıtım (Inheritance)
            // * Kapsülleme (Encapsulation)
            // * Çok Biçimlilik (Poly Morphisim)
            // * Soyutlama (Absiraction)
            int sayi = 5;
            Araba a1 = new Araba();
            a1.marka = "Toyota";
            a1.model = "Corolla";
            a1.uretimYili = 2024;
            a1.BilgileriGoster();
            Ogrenci o1 = new Ogrenci();
            o1.ad = "Emre";
            o1.soyad = "Gülmez";
            o1.vize = 55;
            o1.final = 37;
            o1.BilgileriGoster();
            Ogrenci o2 = new Ogrenci();
            o2.ad = Console.ReadLine();
            o2.soyad = Console.ReadLine();
            o2.vize = Convert.ToByte(Console.ReadLine());
            o2.final = Convert.ToByte(Console.ReadLine());
            o2.BilgileriGoster();
            Console.ReadKey();
        }
    }
}
