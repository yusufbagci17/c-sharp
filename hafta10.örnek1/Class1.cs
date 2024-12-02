using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta10.örnek1
{
    public class Calisan
    {
        public static string SirketAdi{ get; set; }
        public static int CalisanSayisi {  get; set; }
        
        public int Maas {  get; set; }  
        public string Ad { get; set; }
        public string Soyad { get; set; }
        static Calisan()
        {
            CalisanSayisi = 0; // İlk başta çalışan sayısı sıfır
            Console.WriteLine("Şirket bilgileri yüklendi.");
        }
        public Calisan(string ad, string soyad ,int maas)
        {
            Ad = ad;
            Maas = maas;
            Soyad = soyad;
            CalisanSayisi++;
        }
       

        public static void SirketBilgileriniYazdir()
        {
            Console.WriteLine($"sirket adı :{SirketAdi}");
            Console.WriteLine($"çalışan sayisi:{CalisanSayisi}");
            
        }
        public void CalisanBilgisiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Maaş: {Maas}");
        }
    }
}
