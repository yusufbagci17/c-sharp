using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_3_Kullanici_Girisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullanici_adi = "emre";
            string sifre = "123";
            byte hak = 3;
            do
            {
                Console.WriteLine("Kullanicı adı giriniz: ");
                string kullanici_adi2 = Console.ReadLine();
                Console.WriteLine("Şifre giriniz: ");
                string sifre2 = Console.ReadLine();
                if (kullanici_adi == kullanici_adi2 && sifre == sifre2)
                {
                    Console.WriteLine("Giriş başarılı...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    hak--;
                    Console.WriteLine("Yanlış kullanıcı adı, şifre eşleşmesi...");
                    Console.WriteLine("Kalan hak: " + hak);
                    Console.ReadKey();
                }
            } while (hak > 0);
            if (hak == 0)
            {
                Console.WriteLine("Çok fazla başarısız deneme !");
            }
            Console.WriteLine("Programdan çıkılıyor...");
            Console.ReadKey();
        }
    }
}
