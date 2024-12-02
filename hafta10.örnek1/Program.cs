using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta10.örnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Statik metodu kullanarak şirket bilgilerini yazdıralım
            Console.WriteLine("Şirket bilgileri:");
            Calisan.SirketBilgileriniYazdir();

            // Çalışan bilgilerini eklemek ve yazdırmak
            Console.WriteLine("\nÇalışan bilgileri:");
            Calisan calisan1 = new Calisan("Ahmet", "Yılmaz", 5000);
            calisan1.CalisanBilgisiYazdir();

            Calisan calisan2 = new Calisan("Zeynep", "Demir", 6000);
            calisan2.CalisanBilgisiYazdir();

            // Güncellenmiş şirket bilgilerini kontrol edelim
            Console.WriteLine("\nGüncellenmiş şirket bilgileri:");
            Calisan.SirketBilgileriniYazdir();

            Console.ReadLine();
        }
    }
}
