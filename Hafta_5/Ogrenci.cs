using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_5
{
    public class Ogrenci
    {
        public string ad;
        public string soyad;
        public byte vize;
        public byte final;

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {ad}\nSoyad: {soyad}\nOrtalama: {OrtalamaHesapla()} ");
        }
        public string OrtalamaHesapla()
        {
            return Convert.ToString((Convert.ToSingle(vize) / 100 * 40 + Convert.ToSingle(final) / 100 * 60));
        }
    }
}
