using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _9.hafta_3.ornek;

namespace _9.hafta_3.örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // İlk çalışan nesnesini oluşturuyoruz.
            Calisanlar calisan1 = new Calisanlar();
            calisan1.ad = "Ahmet";
            calisan1.soyad = "Yılmaz";
            calisan1.maas = 4500;

            // İkinci çalışan nesnesi (hatalı veri).
            Calisanlar calisan2 = new Calisanlar();
            calisan2.ad = ""; // Ad boş olamaz.
            calisan2.soyad = "Kaya";
            calisan2.maas = -2000; // Maaş sıfırdan büyük olmalıdır!

            // Çalışan bilgilerini yazdırıyoruz.
            Console.WriteLine("Çalışan 1 Bilgileri:");
            calisan1.BilgileriGoster();

            Console.WriteLine("\nÇalışan 2 Bilgileri:");
            calisan2.BilgileriGoster();
        }
    }
}

    

